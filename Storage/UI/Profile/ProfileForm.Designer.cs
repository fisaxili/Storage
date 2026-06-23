namespace Storage.UI.Profile
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop      = new Panel();
            lblAppBar     = new Label();
            panelCard     = new Panel();
            lblAvatarBg   = new Panel();
            lblAvatar     = new Label();
            lblLoginVal   = new Label();
            lblRoleBadge  = new Label();
            groupPassword = new GroupBox();
            lblOldPass    = new Label();
            txtOldPass    = new TextBox();
            lblNewPass    = new Label();
            txtNewPass    = new TextBox();
            lblConfirmLbl = new Label();
            txtConfirm    = new TextBox();
            btnChangePassword = new Button();

            panelTop.SuspendLayout();
            panelCard.SuspendLayout();
            lblAvatarBg.SuspendLayout();
            groupPassword.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────────
            ClientSize      = new Size(460, 480);
            Text            = "Личный кабинет";
            StartPosition   = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            BackColor       = Theme.BgPage;
            Font            = Theme.FontBase;
            Load           += ProfileForm_Load;

            // ── panelTop ──────────────────────────────────────────────
            panelTop.BackColor = Theme.Accent;
            panelTop.Dock      = DockStyle.Top;
            panelTop.Height    = 48;

            lblAppBar.Text      = "👤  Личный кабинет";
            lblAppBar.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location  = new Point(16, 12);
            lblAppBar.AutoSize  = true;
            panelTop.Controls.Add(lblAppBar);

            // ── panelCard — аватар + имя + роль ───────────────────────
            panelCard.BackColor = Color.White;
            panelCard.Location  = new Point(20, 60);
            panelCard.Size      = new Size(420, 90);

            // Круглый «аватар»
            lblAvatarBg.BackColor = Theme.Accent;
            lblAvatarBg.Location  = new Point(15, 15);
            lblAvatarBg.Size      = new Size(60, 60);

            lblAvatar.Text      = "👤";
            lblAvatar.Font      = new Font("Segoe UI", 22f);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location  = new Point(10, 12);
            lblAvatar.AutoSize  = true;
            lblAvatarBg.Controls.Add(lblAvatar);

            lblLoginVal.Text      = "";
            lblLoginVal.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblLoginVal.ForeColor = Theme.TextPrimary;
            lblLoginVal.Location  = new Point(90, 15);
            lblLoginVal.AutoSize  = true;

            lblRoleBadge.Text      = "";
            lblRoleBadge.Font      = Theme.FontBold;
            lblRoleBadge.ForeColor = Color.White;
            lblRoleBadge.BackColor = Theme.AccentLight;
            lblRoleBadge.Location  = new Point(90, 46);
            lblRoleBadge.AutoSize  = true;
            lblRoleBadge.Padding   = new Padding(6, 2, 6, 2);

            panelCard.Controls.AddRange(new Control[]
                { lblAvatarBg, lblLoginVal, lblRoleBadge });

            // ── groupPassword ─────────────────────────────────────────
            groupPassword.Text      = "  Смена пароля";
            groupPassword.Font      = Theme.FontBold;
            groupPassword.ForeColor = Theme.Accent;
            groupPassword.Location  = new Point(20, 165);
            groupPassword.Size      = new Size(420, 280);
            groupPassword.BackColor = Color.White;

            lblOldPass.Text      = "Текущий пароль";
            lblOldPass.Font      = Theme.FontBold;
            lblOldPass.ForeColor = Theme.TextMuted;
            lblOldPass.Location  = new Point(15, 28);
            lblOldPass.AutoSize  = true;

            txtOldPass.Location     = new Point(15, 48);
            txtOldPass.Size         = new Size(385, 28);
            txtOldPass.PasswordChar = '●';
            txtOldPass.BorderStyle  = BorderStyle.FixedSingle;
            txtOldPass.BackColor    = Color.FromArgb(248, 251, 248);

            lblNewPass.Text      = "Новый пароль  (не менее 6 символов)";
            lblNewPass.Font      = Theme.FontBold;
            lblNewPass.ForeColor = Theme.TextMuted;
            lblNewPass.Location  = new Point(15, 88);
            lblNewPass.AutoSize  = true;

            txtNewPass.Location     = new Point(15, 108);
            txtNewPass.Size         = new Size(385, 28);
            txtNewPass.PasswordChar = '●';
            txtNewPass.BorderStyle  = BorderStyle.FixedSingle;
            txtNewPass.BackColor    = Color.FromArgb(248, 251, 248);

            lblConfirmLbl.Text      = "Подтвердите новый пароль";
            lblConfirmLbl.Font      = Theme.FontBold;
            lblConfirmLbl.ForeColor = Theme.TextMuted;
            lblConfirmLbl.Location  = new Point(15, 148);
            lblConfirmLbl.AutoSize  = true;

            txtConfirm.Location     = new Point(15, 168);
            txtConfirm.Size         = new Size(385, 28);
            txtConfirm.PasswordChar = '●';
            txtConfirm.BorderStyle  = BorderStyle.FixedSingle;
            txtConfirm.BackColor    = Color.FromArgb(248, 251, 248);

            btnChangePassword.Text     = "Изменить пароль";
            btnChangePassword.Location = new Point(15, 215);
            btnChangePassword.Size     = new Size(385, 40);
            Theme.StyleAccentButton(btnChangePassword);
            btnChangePassword.Font   = new Font("Segoe UI", 10f, FontStyle.Bold);
            btnChangePassword.Click += btnChangePassword_Click;

            groupPassword.Controls.AddRange(new Control[]
            {
                lblOldPass, txtOldPass, lblNewPass, txtNewPass,
                lblConfirmLbl, txtConfirm, btnChangePassword
            });

            Controls.AddRange(new Control[] { panelTop, panelCard, groupPassword });

            panelTop.ResumeLayout();
            panelCard.ResumeLayout();
            lblAvatarBg.ResumeLayout();
            groupPassword.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel    panelTop, panelCard, lblAvatarBg;
        private Label    lblAppBar, lblAvatar, lblLoginVal, lblRoleBadge;
        private GroupBox groupPassword;
        private Label    lblOldPass, lblNewPass, lblConfirmLbl;
        private TextBox  txtOldPass, txtNewPass, txtConfirm;
        private Button   btnChangePassword;
    }
}
