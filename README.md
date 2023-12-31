# Screen Sound

Projeto que estou desenvolvendo na formação "Aprenda a programar em C# com Orientação a Objetos" da Alura.

Se trata de um sistema de catálogo de músicas similar ao Spotify, mas só com as informações do catálogo mesmo, não tem player de música nem nada do tipo.

## C#: dominando a Orientação a Objetos

Neste curso irei entender melhor como aplicar a orientação a objetos no C#.

### Aula 1

#### Entendendo namespaces

Nesta aula aprendi o que são namespaces e vi um pouco das boas práticas que devemos tomar quando estamos criando eles.

### Aula 2

#### Entendendo modificador internal e mais

Nesta aula aprendi sobre o modificador de visibilidade "internal", que define que a classe em questão só pode ser utilizada dentro do projeto em que ela está inserida, além de ter visto que a classe "Program" sempre é convertida automaticamente pelo compilador para conter o método "Main", de forma que conseguimos escrever o código sem precisarmos nos preocupar com ele estar dentro de uma classe ou não.

### Aula 3

#### Entendendo herança

Nesta aula vi como utilizar a herança no C#.

Aprendi também a sobrescrever os métodos e as palavras chave "virtual" e "override".

### Aula 4

#### Entendendo interfaces

Nesta aula aprendi a utilizar interfaces no C#.

Além disso, vi que todos os tipos do C# herdam de Object em sua hierarquia, que possui métodos como "ToString()", "Equals()" e "GetHashCode()", assim como no Java.

Também dei uma olhada nas documentações de "List<>" e "IEnumerable<>" e vi que é uma boa utilizar o IEnumerable quando queremos uma coleção iterável mas que não dê a facilidade de adicionar e remover itens, assim protegendo nossas coleções e deixando o código mais encapsulado.

### Aula 5

#### Integrando com biblioteca externa

Nesta aula aprendi a adicionar novas bibliotecas no nosso projeto com o NuGet, utilizando o gerenciador de pacotes do NuGet do VisualStudio.

No curso foi mostrado como integrar com a API da OpenAI, que nos dá acesso à API do ChatGPT, DALL-E e outros serviços da OpenAI.

Além disso, aprendi mais sobre o "async & await" no C#, vendo como criar um método "async" e como esperar o retorno de uma Task sem utilizar a palavra-chave "await".

Muito interessante ver como o JavaScript tem coisas tanto do Java quanto do C#.

### Conclusão

Neste curso aprendi bastante coisa de como utilizar a orientação a objetos no C#, assim como mais detalhes e peculiaridades da linguagem que eu ainda não estava familizarizado.

Aprendi novas palavras-chave, conceito de namespaces, mais detalhes sobre as coleções no C# e operações assíncronas.

Foi um curso muito bom no geral, apesar de eu já ter conhecimento sobre orientação a objetos. Deu pra tirar bastante proveito dos detalhes da linguagem.

## C#: consumindo API, gravando arquivos e utilizando o LINQ

Neste curso irei aprender a como consumir APIs realizando requisições HTTP no C#, mexer com arquivos do sistema e utilizar o LINQ.

### Aula 1

#### HttpClient e try-catch

Nesta aula aprendi a executar uma requisição que retorna a resposta em string de forma assíncrona, utilizando o await para aguardar a finalização da Task.

Além disso, vi como fazer um try-catch no C#, que não se difere muito de um try-catch no Java.

### Aula 2

#### Serialização/Desserialização JSON

Nesta aula aprendi a mapear respostas JSON para classes do C# utilizando algumas classes de "System.Text.Json", como "JsonSerializer" e a annotation (não sei se é certo chamar assim no C#) "JsonPropertyName()", assim como detalhes de como fazer esse processo de conversão funcionar.

### Aula 3

#### LINQ (Language Integrated Query)

Nesta aula aprendi a realizar consultas, filtragens, ordenações e muitas outras coisas utilizando o LINQ, biblioteca que torna muito mais fácil a manipulação de bases de dados.

Achei muito interessante a utilização do LINQ, pois tudo que fiz foi utilizando métodos que já ficam disponíveis nas próprias coleções em que estamos trabalhando, tornando muito fácil o processo de encadear métodos conforme a nossa necessidade.

### Aula 4

#### Trabalhando com IO

Nesta aula aprendi como gerar um arquivo JSON utilizando a classe "File" do namespace "System.IO", assim como arquivos txt utilizando a classe "StreamWriter".

Além disso, vi que é possível criar objetos anônimos no C#, o que ajuda quando queremos um objeto genérico para representar um objeto JSON sem termos que criar uma classe para isso.

### Aula 5

#### Resolvendo desafios

Nesta aula resolvi dois desafios que envolveram tanto a conversão de JSON para objetos C#, quanto a utilização do LINQ para filtrar a lista de músicas por tonalidade da música.

Foi um aula boa para praticar o que foi visto nas outras.

### Conclusão

Neste curso aprendi a trabalhar com dados em formato JSON no C#, fazer a serialização de desserialização desses dados, fazer requisições com o HttpClient, fazer filtros e ordenações utilizando o LINQ, fazer leitura e escrita de arquivos com algumas classes do System.IO, entre outras coisas.

Foi um curso bem interessante, principalmente tudo que foi mostrado do LINQ, gostei muito da facilidade com que conseguimos manipular as coleções com ele.

Agora sinto que entendo um pouco mais de C# e estou gostando bastante da linguagem.
