using Audiobookshelf.ApiClient;

namespace TestApp
{
    internal class Program
    {
        private static AudiobookshelfApiClient _absClient;
        static void Main(string[] args)
        {
            Console.Write("Domain to connect to: ");
            var url = Console.ReadLine();
            _absClient = new AudiobookshelfApiClient(url);
            RunProgramAsync();
        }

        private static async void RunProgramAsync()
        {
            try
            {
                Console.Write("Username: ");
                var username = Console.ReadLine();
                Console.Write("Password: ");
                var password = ReadPassword();
                Console.WriteLine("Logging in...");

                var loginResponse = await _absClient.Login(username, password);

                Console.WriteLine($"Login-response has http-response {loginResponse.StatusCode}.");

                if (loginResponse.IsSuccess)
                {
                    Console.WriteLine("Login was successful. You are now logged in.");
                    await RunLoggedInMenu();
                }
                else
                {
                    Console.WriteLine("Login was unsuccessful, the returned errormessage is: " + loginResponse.ErrorMessage);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Got exception: " + e);
            }
        }

        private static async Task RunLoggedInMenu()
        {
            var quit = false;
            do
            {
                var key = Console.ReadLine();

                switch(key)
                {
                    case "quit":
                        quit = true;
                        break;
                }

            } while (!quit);
            Console.WriteLine("Logging out...");
            var logoutResponse = await _absClient.Logout();
            Console.WriteLine("Quit the program...");
        }

        private static string ReadPassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return pass;
        }
    }
}