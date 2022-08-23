// See https://aka.ms/new-console-template for more information

using GameProject;

using System.Collections.Generic;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear = 2001, FirstName = "Nihal", LastName = "Kadakal", IdentityNumber = 153 });

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(new Campaign { });


