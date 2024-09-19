using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace CaptchaManual
{
    public partial class FormMain : Form
    {
        private Settings? _settings;
        private ProjectSettings? _projectSettings;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                _settings = LoadSettings();
                if (string.IsNullOrEmpty(_settings.DefaultProjectFile)) return;
                _projectSettings = LoadProjectSettings(_settings.DefaultProjectFile);
                if (_projectSettings == null) return;
                txtName.Text = _projectSettings.Name;
                txtDir.Text = _projectSettings.Path;
                txtURL.Text = _projectSettings.URL;
                tlpWork.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            _settings ??= new Settings();
            _settings.DefaultProjectFile = null;
            _projectSettings = null;
            txtName.Text = $"�½���Ŀ{DateTime.Now.ToShortTimeString()}";
            txtDir.Text = string.Empty;
            txtURL.Text = string.Empty;
            tlpWork.Enabled = true;
        }

        private void tsmiImport_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("������Ŀ�Ḳ�ǵ�ǰ��Ŀ���Ƿ������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
                var ofd = new OpenFileDialog
                {
                    Filter = "��Ŀ�ļ�|*.json",
                    Title = "ѡ����Ŀ�ļ�",
                    Multiselect = false
                };
                if (ofd.ShowDialog() != DialogResult.OK) return;
                _settings ??= new Settings();
                _settings.DefaultProjectFile = ofd.FileName;
                _projectSettings = LoadProjectSettings(ofd.FileName);
                if (_projectSettings == null)
                {
                    MessageBox.Show("��Ŀ�ļ���ʽ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtName.Text = _projectSettings.Name;
                txtDir.Text = _projectSettings.Path;
                txtURL.Text = _projectSettings.URL;
                tlpWork.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_projectSettings == null)
                {
                    _projectSettings = new ProjectSettings();
                }
                _projectSettings.Name = txtName.Text;
                _projectSettings.Path = txtDir.Text;
                _projectSettings.URL = txtURL.Text;
                _settings ??= new Settings();
                if (string.IsNullOrEmpty(_settings.DefaultProjectFile))
                {
                    var sfd = new SaveFileDialog
                    {
                        Filter = "��Ŀ�ļ�|*.json",
                        Title = "������Ŀ�ļ�"
                    };
                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    _settings ??= new Settings();
                    _settings.DefaultProjectFile = sfd.FileName;
                }
                SaveProjectSettings(_projectSettings, _settings.DefaultProjectFile);
                SaveSettings(_settings);
                MessageBox.Show("����ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("�Ƿ��˳�����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            Application.Exit();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CaptchaManual v1.0", "����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                Description = "ѡ����ĿĿ¼"
            };
            if (fbd.ShowDialog() != DialogResult.OK) return;
            txtDir.Text = fbd.SelectedPath;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("URL����Ϊ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDir.Text))
            {
                MessageBox.Show("Ŀ¼����Ϊ��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var url = txtURL.Text;
            var dir = txtDir.Text;
            DownloadCaptcha(url, dir);
        }

        private void DownloadCaptcha(string url, string dir)
        {
            Task.Factory.StartNew(async () =>
            {
                var client = new HttpClient();
                var rsp = await client.GetAsync(url);
                var content = await rsp.Content.ReadAsByteArrayAsync();
                Invoke(() =>
                {
                    pbCaptcha.Image = Image.FromStream(new MemoryStream(content));
                    txtCaptcha.Text = "";
                    txtCaptcha.Focus();
                });
            });
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaptcha.Text))
            {
                MessageBox.Show("����������֤��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var url = txtURL.Text;
            var dir = txtDir.Text;
            var captcha = txtCaptcha.Text;
            captcha = ProcessCaptcha(dir, captcha);
            var savePath = Path.Combine(dir, $"{captcha}.jpg");
            if (pbCaptcha.Image == null)
            {
                MessageBox.Show("����������֤��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pbCaptcha.Image.Save(savePath, ImageFormat.Jpeg);
            if (cbAutoDownload.Checked) DownloadCaptcha(url, dir);
            txtCaptcha.Text = "";
            txtCaptcha.Focus();
        }

        private string ProcessCaptcha(string dir, string captcha)
        {
            // ��������
            captcha = Regex.Replace(captcha, @"[\u4e00-\u9fa5]", m => $"0x{Convert.ToInt32(m.Value[0]):X}");
            // ȥ���ո�
            captcha = captcha.Replace(" ", "");
            // ȥ�������ַ�
            captcha = captcha.Replace("*", "x");
            captcha = captcha.Replace("X", "x");
            captcha = captcha.Replace("��", "x");
            // �ж��ظ�
            var count = Directory.GetFiles(dir, $"{captcha}*.jpg").Length;
            if (count > 0) captcha = $"{captcha}_{count}";
            return captcha;
        }

        public class Settings
        {
            public string? DefaultProjectFile { get; set; }
        }

        private static string SettingsFilePath
        {
            get
            {
                var userDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var appDataPath = Path.Combine(userDataPath, "CaptchaManual");
                if (!Directory.Exists(appDataPath)) Directory.CreateDirectory(appDataPath);
                var settingsPath = Path.Combine(appDataPath, "settings.json");
                return settingsPath;
            }
        }

        private static Settings LoadSettings()
        {
            if (!File.Exists(SettingsFilePath)) return new Settings();
            var json = File.ReadAllText(SettingsFilePath);
            return JsonConvert.DeserializeObject<Settings>(json) ?? new Settings();
        }

        private static void SaveSettings(Settings settings)
        {
            var json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(SettingsFilePath, json);
        }

        public class ProjectSettings
        {
            public string? Name { get; set; }
            public string? Path { get; set; }
            public string? URL { get; set; }
        }

        private static ProjectSettings? LoadProjectSettings(string path)
        {
            if (!File.Exists(path)) return null;
            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<ProjectSettings>(json);
        }

        private static void SaveProjectSettings(ProjectSettings projectSettings, string path)
        {
            var json = JsonConvert.SerializeObject(projectSettings);
            File.WriteAllText(path, json);
        }
    }
}
