using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Json;
using System.Net.Http;

namespace EasyTrack_Dashboard
{
    public partial class Form_AuthenticationWindow : Form
    {
        public Form_AuthenticationWindow()
        {
            InitializeComponent();

            successfulAuthentication = false;
        }

        #region Variables
        private bool successfulAuthentication;
        #endregion

        private void AuthenticationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!successfulAuthentication)
                DialogResult = DialogResult.Cancel;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            pauseLabel.Visible = true;

            new Thread(async () =>
            {
                try
                {
                    HttpResponseMessage result = await Tools.post(
                        Tools.API_AUTHENTICATE,
                        new Dictionary<string, string>
                        {
                            { "username", usernameTextBox.Text },
                            { "password", passwordTextBox.Text },
                            { "type", "experimenter" }
                        }
                    );
                    if (result.IsSuccessStatusCode)
                    {
                        JsonValue resJson = JsonValue.Parse(await result.Content.ReadAsStringAsync());
                        if (resJson.ContainsKey("result"))
                        {
                            ServerResult resCode = (ServerResult)int.Parse(resJson["result"].ToString());
                            if (resCode == ServerResult.OK)
                            {
                                Properties.Settings.Default.Username = usernameTextBox.Text;
                                Properties.Settings.Default.Password = passwordTextBox.Text;
                                Properties.Settings.Default.Type = "Experimenter";
                                Properties.Settings.Default.LoggedIn = true;
                                Properties.Settings.Default.Save();

                                Tools.runOnUiThread(this, () =>
                                {
                                    successfulAuthentication = true;
                                    DialogResult = DialogResult.OK;
                                    Close();
                                });
                            }
                            else
                            {
                                Thread.Sleep(2000);

                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Incorrect username/password. Please check your inputs and try again!", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Enabled = true;
                                    pauseLabel.Visible = false;
                                });
                            }
                        }
                        else
                        {
                            Tools.runOnUiThread(this, () =>
                            {
                                MessageBox.Show(this, "Unknown error occurred, please refer to the developer of this application!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Enabled = true;
                                pauseLabel.Visible = false;
                            });
                        }
                    }
                    else
                        throw new Exception($"Post request response: {result.StatusCode.ToString()}");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                    Tools.runOnUiThread(this, () =>
                    {
                        MessageBox.Show(this, "Failed to connect to server, plase check your internet connection!", "Connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }

            }).Start();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            pauseLabel.Visible = true;

            new Thread(async () =>
            {
                try
                {
                    HttpResponseMessage result = await Tools.post(
                        Tools.API_REGISTER,
                        new Dictionary<string, string>
                        {
                            { "username", usernameTextBox.Text },
                            { "password", passwordTextBox.Text },
                            { "type", "experimenter" }
                        }
                    );
                    if (result.IsSuccessStatusCode)
                    {
                        JsonValue resJson = JsonValue.Parse(await result.Content.ReadAsStringAsync());
                        if (resJson.ContainsKey("result"))
                        {
                            ServerResult resCode = (ServerResult)int.Parse(resJson["result"].ToString());
                            if (resCode == ServerResult.OK)
                            {
                                Thread.Sleep(2000);
                                Tools.runOnUiThread(this, () =>
                                {
                                    string message = "Experimenter account has been created!\nYou can log in now!";
                                    if (resJson.ContainsKey("note"))
                                        message += $"\n\nNote: {resJson["note"].ToString()}";
                                    MessageBox.Show(this, message, "Account created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Enabled = true;
                                    pauseLabel.Visible = false;
                                });
                            }
                            else if (resCode == ServerResult.TOO_LONG_PASSWORD)
                            {
                                Thread.Sleep(2000);
                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Too long password, please reduce it by maximum 12 characters!", "Password length issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Enabled = true;
                                    pauseLabel.Visible = false;
                                });
                            }
                            else if (resCode == ServerResult.TOO_SHORT_PASSWORD)
                            {
                                Thread.Sleep(2000);
                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Too short password, please increase it by minimum 8 characters!", "Password length issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Enabled = true;
                                    pauseLabel.Visible = false;
                                });
                            }
                            else if (resCode == ServerResult.USERNAME_TAKEN)
                            {
                                Thread.Sleep(2000);
                                Tools.runOnUiThread(this, () =>
                                {
                                    MessageBox.Show(this, "Username is taken, please pick another one!", "Username is taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Enabled = true;
                                    pauseLabel.Visible = false;
                                });
                            }
                        }
                        else
                        {
                            Tools.runOnUiThread(this, () =>
                            {
                                MessageBox.Show(this, "Unknown error occurred, please refer to the developer of this application!", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Enabled = true;
                                pauseLabel.Visible = false;
                            });
                        }
                    }
                    else
                        throw new Exception($"Post request response: {result.StatusCode.ToString()}");
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.ToString());
                    Tools.runOnUiThread(this, () =>
                    {
                        MessageBox.Show(this, "Failed to connect to server, plase check your internet connection!", "Connection failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Enabled = true;
                        pauseLabel.Visible = false;
                    });
                }

            }).Start();
        }
    }
}
