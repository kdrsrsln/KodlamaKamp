using System;

namespace _5GunOdev5GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            GameManager gameManager = new GameManager();
            Gamer gamer = new Gamer();
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            Game game = new Game{Name = "Fifa21", Type = "Sport",Price = 100}; 
            var menu = MenuSelection();

            switch (menu)
            {
                case 1:
                    Console.WriteLine("To pass user validation use these info :\nKadir\nSarıaslan\n1988\n123654789");
                    Console.WriteLine("FirstName : ");
                    gamer.FirstName = Console.ReadLine();
                    Console.WriteLine("LastName : ");
                    gamer.LastName = Console.ReadLine();
                    Console.WriteLine("BirthYear : ");
                    gamer.BirthYear = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("IdentityNumber : ");
                    gamer.IdentityNumber = Console.ReadLine();
                    gamerManager.Add(gamer);
                    break;
                case 2:
                    Console.WriteLine("update your info :\n FirstName : ");
                    gamer.FirstName = Console.ReadLine();
                    Console.WriteLine("LastName : ");
                    gamer.LastName = Console.ReadLine();
                    Console.WriteLine("BirthYear : ");
                    gamer.BirthYear = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("IdentityNumber : ");
                    gamer.IdentityNumber = Console.ReadLine();
                    gamerManager.Update(gamer);
                    break;
                case 3:
                    Console.WriteLine("Are you sure to delete your profile?\n1- Yes\n2- No");
                    if (Convert.ToInt16(Console.ReadLine())==2)
                    {
                        Console.WriteLine("Process canceled!");
                    }
                    else
                    {
                        gamerManager.Delete(gamer);
                    }
                    break;
                case 4:
                    Console.WriteLine("Campaign Name : ");
                    campaign.Name = Console.ReadLine();
                    Console.WriteLine("Discount price :");
                    campaign.Discount = Convert.ToDecimal(Console.ReadLine());
                    campaignManager.Add(campaign);
                    break;
                case 5:
                    Console.WriteLine("Update Campaign Info :");
                    Console.WriteLine("Campaign Name : ");
                    campaign.Name = Console.ReadLine();
                    Console.WriteLine("Discount price :");
                    campaign.Discount = Convert.ToDecimal(Console.ReadLine());
                    campaignManager.Update(campaign);
                    break;
                case 6:
                    Console.WriteLine("Are you sure to delete Campaign?\n1- Yes\n2- No");
                    if (Convert.ToInt16(Console.ReadLine()) == 2)
                    {
                        Console.WriteLine("Process canceled!");
                    }
                    else
                    {
                        campaignManager.Delete(campaign);
                    }
                    break;
                case 7:
                    gameManager.Purchase(game,gamer);
                    break;

            }

            int MenuSelection()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("1) Add Gamer");
                Console.WriteLine("2) Update Gamer");
                Console.WriteLine("3) Delete Gamer");
                Console.WriteLine("4) Add Campaign");
                Console.WriteLine("5) Update Campaign");
                Console.WriteLine("6) Delete Campaign");
                Console.WriteLine("7) Purchase Game");
                Console.Write("İşlem Seçiniz: ");
                int process = Convert.ToInt32(Console.ReadLine());
                return process;
            }
        }
    }
}
