using ScreenSound.Menus;
using ScreenSound.Modelos;

Menu menuBemVindo = new MenuBemVindo("Bem vindo(a) ao Screen Sound");
menuBemVindo.Executar();

Console.Clear();

Artista metallica = new("Metallica");
Album blackAlbum = new("Black Album", metallica);
Musica enterSandman = new("Enter Sandman", "Metal", 331, metallica, blackAlbum);
Musica sadButTrue = new("Sad But True", "Metal", 323, metallica, blackAlbum);

Console.WriteLine(blackAlbum);
