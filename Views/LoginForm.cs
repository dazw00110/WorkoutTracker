using System;
using System.Windows.Forms;

namespace WorkoutTracker.Views
{
    public partial class LoginForm : Form
    {
        // Kontrolki loginu
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsernameEmail;
        private TextBox txtUsernameEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkRegister;

        // Kontrolki rejestracji
        private Label lblRegTitle;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblRegUsername;
        private TextBox txtRegUsername;
        private Label lblRegEmail;
        private TextBox txtRegEmail;
        private Label lblRegPassword;
        private TextBox txtRegPassword;
        private Label lblRegPasswordConfirm;
        private TextBox txtRegPasswordConfirm;
        private Label lblWeight;
        private TextBox txtWeight;
        private Label lblHeight;
        private TextBox txtHeight;
        private Button btnRegister;
        private LinkLabel linkBackToLogin;

        public LoginForm()
        {
            InitializeComponent();
            InitializeLoginComponents();
            InitializeRegisterComponents();

            this.ClientSize = new System.Drawing.Size(400, 600);

            this.Resize += (s, e) =>
            {
                if (lblTitle.Visible) LayoutControlsLogin();
                else LayoutControlsRegister();
            };

            ShowLogin();
        }



        private void InitializeLoginComponents()
        {
            int controlWidth = 300;

            lblTitle = new Label()
            {
                Width = controlWidth,
                Height = 50,
                Text = "Workout Tracker",
                Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false
            };

            lblSubtitle = new Label()
            {
                Width = controlWidth,
                Height = 30,
                Text = "Śledź swoje treningi",
                Font = new System.Drawing.Font("Segoe UI", 12F),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false
            };

            lblUsernameEmail = new Label()
            {
                Width = controlWidth,
                Text = "Nazwa użytkownika lub email:",
                AutoSize = false,
            };

            txtUsernameEmail = new TextBox()
            {
                Width = controlWidth,
            };

            lblPassword = new Label()
            {
                Width = controlWidth,
                Text = "Hasło:",
                AutoSize = false,
            };

            txtPassword = new TextBox()
            {
                Width = controlWidth,
                UseSystemPasswordChar = true
            };

            btnLogin = new Button()
            {
                Width = controlWidth,
                Text = "Zaloguj się"
            };

            linkRegister = new LinkLabel()
            {
                Width = controlWidth,
                Text = "Nie masz konta? Zarejestruj się",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            this.Controls.AddRange(new Control[] { lblTitle, lblSubtitle, lblUsernameEmail, txtUsernameEmail, lblPassword, txtPassword, btnLogin, linkRegister });

            linkRegister.LinkClicked += (s, e) => ShowRegister();

            btnLogin.Click += (s, e) =>
            {
                MessageBox.Show("Logowanie jeszcze nie zaimplementowane.");
            };
        }

        private void InitializeRegisterComponents()
        {
            int controlWidth = 300;

            lblRegTitle = new Label()
            {
                Text = "Rejestracja nowego użytkownika",
                Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                Width = controlWidth,
                Height = 40,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                AutoSize = false
            };

            lblFirstName = new Label() { Text = "Imię:", Width = controlWidth, AutoSize = false };
            txtFirstName = new TextBox() { Width = controlWidth };

            lblLastName = new Label() { Text = "Nazwisko:", Width = controlWidth, AutoSize = false };
            txtLastName = new TextBox() { Width = controlWidth };

            lblRegUsername = new Label() { Text = "Nazwa użytkownika:", Width = controlWidth, AutoSize = false };
            txtRegUsername = new TextBox() { Width = controlWidth };

            lblRegEmail = new Label() { Text = "Email:", Width = controlWidth, AutoSize = false };
            txtRegEmail = new TextBox() { Width = controlWidth };

            lblRegPassword = new Label() { Text = "Hasło:", Width = controlWidth, AutoSize = false };
            txtRegPassword = new TextBox() { Width = controlWidth, UseSystemPasswordChar = true };

            lblRegPasswordConfirm = new Label() { Text = "Powtórz hasło:", Width = controlWidth, AutoSize = false };
            txtRegPasswordConfirm = new TextBox() { Width = controlWidth, UseSystemPasswordChar = true };

            lblWeight = new Label() { Text = "Waga (kg):", Width = controlWidth, AutoSize = false };
            txtWeight = new TextBox() { Width = controlWidth };

            lblHeight = new Label() { Text = "Wzrost (cm):", Width = controlWidth, AutoSize = false };
            txtHeight = new TextBox() { Width = controlWidth };

            btnRegister = new Button() { Text = "Zarejestruj się", Width = controlWidth };
            linkBackToLogin = new LinkLabel() { Text = "Masz konto? Zaloguj się", Width = controlWidth, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };

            btnRegister.Click += BtnRegister_Click;
            linkBackToLogin.LinkClicked += (s, e) => ShowLogin();

            this.Controls.AddRange(new Control[]
            {
                lblRegTitle, lblFirstName, txtFirstName, lblLastName, txtLastName,
                lblRegUsername, txtRegUsername, lblRegEmail, txtRegEmail,
                lblRegPassword, txtRegPassword, lblRegPasswordConfirm, txtRegPasswordConfirm,
                lblWeight, txtWeight, lblHeight, txtHeight,
                btnRegister, linkBackToLogin
            });
        }

        private void ShowLogin()
        {
            this.Text = "Workout Tracker - Logowanie";

            // Pokaż login
            foreach (Control c in this.Controls)
            {
                if (c == lblTitle || c == lblSubtitle || c == lblUsernameEmail || c == txtUsernameEmail ||
                    c == lblPassword || c == txtPassword || c == btnLogin || c == linkRegister)
                    c.Visible = true;
                else
                    c.Visible = false;
            }

            LayoutControlsLogin();
        }

        private void ShowRegister()
        {
            this.Text = "Workout Tracker - Rejestracja";

            // Pokaż rejestrację
            foreach (Control c in this.Controls)
            {
                if (c == lblRegTitle || c == lblFirstName || c == txtFirstName || c == lblLastName || c == txtLastName ||
                    c == lblRegUsername || c == txtRegUsername || c == lblRegEmail || c == txtRegEmail ||
                    c == lblRegPassword || c == txtRegPassword || c == lblRegPasswordConfirm || c == txtRegPasswordConfirm ||
                    c == lblWeight || c == txtWeight || c == lblHeight || c == txtHeight ||
                    c == btnRegister || c == linkBackToLogin)
                    c.Visible = true;
                else
                    c.Visible = false;
            }

            LayoutControlsRegister();
        }

        private void LayoutControlsLogin()
        {
            int spacing = 10;
            int top = 30;
            int centerX = (this.ClientSize.Width - lblTitle.Width) / 2;

            void Center(Control c)
            {
                c.Left = centerX;
            }

            lblTitle.Top = top;
            Center(lblTitle);
            top += lblTitle.Height + spacing;

            lblSubtitle.Top = top;
            Center(lblSubtitle);
            top += lblSubtitle.Height + spacing;

            lblUsernameEmail.Top = top;
            Center(lblUsernameEmail);
            top += lblUsernameEmail.Height + spacing;

            txtUsernameEmail.Top = top;
            Center(txtUsernameEmail);
            top += txtUsernameEmail.Height + spacing;

            lblPassword.Top = top;
            Center(lblPassword);
            top += lblPassword.Height + spacing;

            txtPassword.Top = top;
            Center(txtPassword);
            top += txtPassword.Height + spacing;

            btnLogin.Top = top;
            Center(btnLogin);
            top += btnLogin.Height + spacing;

            linkRegister.Top = top;
            Center(linkRegister);
        }

        private void LayoutControlsRegister()
        {
            int spacing = 10;
            int top = 20;
            int centerX = (this.ClientSize.Width - lblRegTitle.Width) / 2;

            void Center(Control c)
            {
                c.Left = centerX;
            }

            lblRegTitle.Top = top;
            Center(lblRegTitle);
            top += lblRegTitle.Height + spacing;

            lblFirstName.Top = top;
            Center(lblFirstName);
            top += lblFirstName.Height + spacing;

            txtFirstName.Top = top;
            Center(txtFirstName);
            top += txtFirstName.Height + spacing;

            lblLastName.Top = top;
            Center(lblLastName);
            top += lblLastName.Height + spacing;

            txtLastName.Top = top;
            Center(txtLastName);
            top += txtLastName.Height + spacing;

            lblRegUsername.Top = top;
            Center(lblRegUsername);
            top += lblRegUsername.Height + spacing;

            txtRegUsername.Top = top;
            Center(txtRegUsername);
            top += txtRegUsername.Height + spacing;

            lblRegEmail.Top = top;
            Center(lblRegEmail);
            top += lblRegEmail.Height + spacing;

            txtRegEmail.Top = top;
            Center(txtRegEmail);
            top += txtRegEmail.Height + spacing;

            lblRegPassword.Top = top;
            Center(lblRegPassword);
            top += lblRegPassword.Height + spacing;

            txtRegPassword.Top = top;
            Center(txtRegPassword);
            top += txtRegPassword.Height + spacing;

            lblRegPasswordConfirm.Top = top;
            Center(lblRegPasswordConfirm);
            top += lblRegPasswordConfirm.Height + spacing;

            txtRegPasswordConfirm.Top = top;
            Center(txtRegPasswordConfirm);
            top += txtRegPasswordConfirm.Height + spacing;

            lblWeight.Top = top;
            Center(lblWeight);
            top += lblWeight.Height + spacing;

            txtWeight.Top = top;
            Center(txtWeight);
            top += txtWeight.Height + spacing;

            lblHeight.Top = top;
            Center(lblHeight);
            top += lblHeight.Height + spacing;

            txtHeight.Top = top;
            Center(txtHeight);
            top += txtHeight.Height + spacing;

            btnRegister.Top = top;
            Center(btnRegister);
            top += btnRegister.Height + spacing;

            linkBackToLogin.Top = top;
            Center(linkBackToLogin);
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Prosta walidacja
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtRegUsername.Text) ||
                string.IsNullOrWhiteSpace(txtRegEmail.Text) ||
                string.IsNullOrWhiteSpace(txtRegPassword.Text) ||
                string.IsNullOrWhiteSpace(txtRegPasswordConfirm.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.");
                return;
            }

            if (txtRegPassword.Text != txtRegPasswordConfirm.Text)
            {
                MessageBox.Show("Hasła nie są takie same.");
                return;
            }

            if (!int.TryParse(txtWeight.Text, out int weight) || weight <= 0)
            {
                MessageBox.Show("Waga musi być dodatnią liczbą całkowitą.");
                return;
            }

            if (!int.TryParse(txtHeight.Text, out int height) || height <= 0)
            {
                MessageBox.Show("Wzrost musi być dodatnią liczbą całkowitą.");
                return;
            }

            // Tu możesz dodać zapis do bazy lub dalszą logikę
            MessageBox.Show($"Zarejestrowano użytkownika:\n{txtFirstName.Text} {txtLastName.Text}\n" +
                            $"Nazwa: {txtRegUsername.Text}\nEmail: {txtRegEmail.Text}\n" +
                            $"Waga: {weight} kg, Wzrost: {height} cm");

            ShowLogin(); // wróć do logowania po rejestracji
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

