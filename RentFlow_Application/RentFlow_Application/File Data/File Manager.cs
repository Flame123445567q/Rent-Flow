using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using RentFlow_Application.Classes;


 
namespace RentFlow_Application
{
    public class FileManager
    {
        private const string USERS_FILE = "users.txt";

        // ============================================================
        // SAVE USERS TO FILE
        // ============================================================
        public static void SaveUsers(List<User> users)
        {
            try
            {
                // SAFETY CHECK: If the list is null, exit
                if (users == null)
                {
                    MessageBox.Show("Error: User list is null. Cannot save.", "Save Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // SAFETY CHECK: If the list is empty, show warning
                if (users.Count == 0)
                {
                    MessageBox.Show("No users to save.", "Save Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<string> lines = new List<string>();

                foreach (User user in users)
                {
                    // SAFETY CHECK: Skip null users
                    if (user == null) continue;

                    string line = $"{user.Role ?? "Landlord"}|{user.FullName ?? "Unknown"}|{user.Surname ?? "Unknown"}|{user.IDNumber ?? "0000000000000"}|{user.Email ?? "unknown@email.com"}|{user.PhoneNumber ?? "0000000000"}|{user.Password ?? "default"}";
                    lines.Add(line);
                }

                // SAFETY CHECK: Make sure we have lines to save
                if (lines.Count > 0)
                {
                    File.WriteAllLines(USERS_FILE, lines);
                }
                else
                {
                    MessageBox.Show("No valid users to save.", "Save Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving users: {ex.Message}", "Save Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // LOAD USERS FROM FILE
        // ============================================================
        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();

            try
            {
                if (File.Exists(USERS_FILE))
                {
                    string[] lines = File.ReadAllLines(USERS_FILE);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split('|');

                        if (parts.Length >= 7)
                        {
                            User user = new User
                            {
                                Role = parts[0] ?? "Landlord",
                                FullName = parts[1] ?? "Unknown",
                                Surname = parts[2] ?? "Unknown",
                                IDNumber = parts[3] ?? "0000000000000",
                                Email = parts[4] ?? "unknown@email.com",
                                PhoneNumber = parts[5] ?? "0000000000",
                                Password = parts[6] ?? "default"
                            };

                            users.Add(user);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Load Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return users;  //  ALWAYS returns a list (never null!)
        }
    }
}