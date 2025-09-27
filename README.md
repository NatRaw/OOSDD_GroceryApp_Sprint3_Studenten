# GroceryApp sprint3 Studentversie  
    
## UC07 Delen boodschappenlijst  
Is compleet  
  
## UC08 Zoeken producten  
Aanvullen:
- In de GroceryListItemsView zitten twee Collection Views, namelijk één voor de inhoud van de boodschappenlijst en één voor producten die je toe kunt voegen aan de boodschappenlijst  
- Voeg boven de tweede CollectionView een zoekveld (SearchBar) in om op producten te kunnen zoeken.  
- Zorg dat de SearchCommand wordt gebonden aan een functie in het onderliggende ViewModel (GroceryListItemsViewModel) en dat de zoekterm die in het zoekveld is ingetypt gebruikt wordt als parameter (SearchCommandParameter).  
- Werk in het viewModel (GroceryListItemsViewModel) de zoekfunctie uit en zorg dat de beschikbare producten worden gefilterd op de zoekterm!  

## UC09 Registratie gebruiker 
Aanvullen:
- Voeg UserRegistrationView.xaml en UserRegistrationView.xaml.cs toe in Views.
- Voeg UserRegistrationViewModel.cs toe in ViewModels en bind invoervelden Voornaam, e-mail, Wachtwoord.
- Voeg in LoginView.xaml een Registreren-knop toe die naar UserRegistrationView navigeert.
- Registreer de route in AppShell.xaml.cs (bijvoobeeld. Routing.RegisterRoute(Register, typeof(UserRegistrationView));).
- Registreer View + ViewModel (en benodigde services) in MauiProgram.cs.
- Implementeer in UserRegistrationViewModel een RegisterCommand die valideert verplichte velden, wachtwoorden, e-maill.
- Laat RegisterCommand via AuthService/ClientService de nieuwe gebruiker aanmaken en opslaan via IClientRepository.
- Toon feedback succes als registratie is gelukt.
- Breid waar nodig de interfaces uit IClientService, IClientRepository, IAuthService met registratiemethodes.
- Zorg dat App.xaml.cs/AppShell de login/registratie-flow activeert (Login als start; registratie-route beschikbaar).
