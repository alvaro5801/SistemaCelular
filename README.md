# Sistema de Celulares em .NET (Desafio de POO)

![.NET](https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet&style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-11.0-blue?logo=c-sharp&style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)

## 📝 Descrição do Projeto

Este projeto foi desenvolvido como uma solução para um desafio de programação que pedia a modelagem de um sistema de celulares. O objetivo principal é demonstrar a aplicação de conceitos fundamentais da **Programação Orientada a Objetos (POO)** para criar um código flexível, reutilizável e de fácil manutenção.

Através de uma classe abstrata `Celular`, o sistema define um "contrato" comum para todos os celulares. Classes concretas como `Iphone` e `Samsung` herdam desse contrato e implementam seus comportamentos específicos, mostrando como diferentes objetos podem responder de maneiras únicas à mesma ação.

## 🚀 Conceitos de POO Aplicados

Este projeto é um laboratório prático dos seguintes pilares da Orientação a Objetos:

* **Abstração:** A classe `Celular.cs` é abstrata e define os atributos e métodos essenciais que todo celular deve possuir, sem se preocupar com os detalhes de implementação de cada marca.
* **Herança:** As classes `Iphone` e `Samsung` herdam de `Celular`, reutilizando os métodos comuns (como `Ligar()` e `Desligar()`) e evitando a duplicação de código.
* **Polimorfismo:** Métodos como `FazerLigacao()` e `TirarFoto()` são definidos na classe abstrata e sobrescritos (`override`) nas classes filhas, permitindo que cada marca execute a ação de uma maneira particular.
* **Encapsulamento:** Atributos como `_ligado` são protegidos (`protected`), garantindo que o estado interno do objeto só possa ser modificado através dos métodos públicos da classe (`Ligar()` e `Desligar()`), protegendo a integridade dos dados.

## 📂 Estrutura do Projeto

O código está organizado da seguinte forma para promover a clareza e a separação de responsabilidades:

Parceiro de Programacao

Mostrar raciocínio
Com certeza! Um bom README.md é a porta de entrada do seu projeto. Ele valoriza seu trabalho e mostra profissionalismo.

Aqui está uma proposta de README completa, escrita em Markdown. Ela explica o projeto, os conceitos de programação aplicados e como executá-lo.

Instruções:

No seu computador, na pasta do projeto (SistemaCelular), abra o arquivo README.md em um editor de texto (como o VS Code).

Apague o conteúdo que estiver lá e cole o texto abaixo.

Salve o arquivo.

Envie a alteração para o GitHub com os comandos:

PowerShell

git add README.md
git commit -m "docs: Elabora README completo do projeto"
git push origin main
(Copie e cole o texto abaixo no seu arquivo README.md)
Markdown

# Sistema de Celulares em .NET (Desafio de POO)

![.NET](https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet&style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-11.0-blue?logo=c-sharp&style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)

## 📝 Descrição do Projeto

Este projeto foi desenvolvido como uma solução para um desafio de programação que pedia a modelagem de um sistema de celulares. O objetivo principal é demonstrar a aplicação de conceitos fundamentais da **Programação Orientada a Objetos (POO)** para criar um código flexível, reutilizável e de fácil manutenção.

Através de uma classe abstrata `Celular`, o sistema define um "contrato" comum para todos os celulares. Classes concretas como `Iphone` e `Samsung` herdam desse contrato e implementam seus comportamentos específicos, mostrando como diferentes objetos podem responder de maneiras únicas à mesma ação.

## 🚀 Conceitos de POO Aplicados

Este projeto é um laboratório prático dos seguintes pilares da Orientação a Objetos:

* **Abstração:** A classe `Celular.cs` é abstrata e define os atributos e métodos essenciais que todo celular deve possuir, sem se preocupar com os detalhes de implementação de cada marca.
* **Herança:** As classes `Iphone` e `Samsung` herdam de `Celular`, reutilizando os métodos comuns (como `Ligar()` e `Desligar()`) e evitando a duplicação de código.
* **Polimorfismo:** Métodos como `FazerLigacao()` e `TirarFoto()` são definidos na classe abstrata e sobrescritos (`override`) nas classes filhas, permitindo que cada marca execute a ação de uma maneira particular.
* **Encapsulamento:** Atributos como `_ligado` são protegidos (`protected`), garantindo que o estado interno do objeto só possa ser modificado através dos métodos públicos da classe (`Ligar()` e `Desligar()`), protegendo a integridade dos dados.

## 📂 Estrutura do Projeto

O código está organizado da seguinte forma para promover a clareza e a separação de responsabilidades:

/SistemaCelular
|
├── Celular.cs       # Classe abstrata base com o contrato do celular.
├── Iphone.cs        # Classe concreta que representa um iPhone.
├── Samsung.cs       # Classe concreta que representa um Samsung.
└── Program.cs       # Ponto de entrada da aplicação, onde os objetos são criados e testados.

## 💻 Como Executar

Para rodar este projeto em sua máquina local, siga os passos abaixo.

### Pré-requisitos

* [.NET SDK 8.0](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0) ou superior instalado.

### Passo a passo

1.  Clone o repositório para sua máquina:
    ```bash
    git clone [https://github.com/alvaro5801/SistemaCelular.git](https://github.com/alvaro5801/SistemaCelular.git)
    ```

2.  Navegue até o diretório do projeto:
    ```bash
    cd SistemaCelular
    ```

3.  Execute a aplicação:
    ```bash
    dotnet run
    ```

## 📜 Exemplo de Saída

Ao executar o projeto, você verá a seguinte saída no console, demonstrando o comportamento polimórfico de cada objeto:

```console
### Testando o iPhone ###
O iPhone 15 Pro está ligando...
--- Informações do Celular ---
Marca: Apple
Modelo: iPhone 15 Pro
Armazenamento: 256GB
Status: Ligado
-----------------------------
iPhone: Ligando para 99999-1111 com o som característico 'bip bip'.
iPhone: Foto capturada com o sistema de câmera TrueDepth. *click*
Ouvindo... 'E aí, Siri?'
O iPhone 15 Pro está desligando...


### Testando o Samsung ###
O Galaxy S23 Ultra está ligando...
--- Informações do Celular ---
Marca: Samsung
Modelo: Galaxy S23 Ultra
Armazenamento: 512GB
Status: Ligado
-----------------------------
Samsung: Enviando SMS para 88888-2222: 'Olá, tudo bem?'
Samsung: Foto tirada com o 'Space Zoom'. Qualidade aprimorada por IA.
Modo DeX ativado. Transformando seu celular em um desktop.
O Galaxy S23 Ultra está desligando...

Parceiro de Programacao

Mostrar raciocínio
Com certeza! Um bom README.md é a porta de entrada do seu projeto. Ele valoriza seu trabalho e mostra profissionalismo.

Aqui está uma proposta de README completa, escrita em Markdown. Ela explica o projeto, os conceitos de programação aplicados e como executá-lo.

Instruções:

No seu computador, na pasta do projeto (SistemaCelular), abra o arquivo README.md em um editor de texto (como o VS Code).

Apague o conteúdo que estiver lá e cole o texto abaixo.

Salve o arquivo.

Envie a alteração para o GitHub com os comandos:

PowerShell

git add README.md
git commit -m "docs: Elabora README completo do projeto"
git push origin main
(Copie e cole o texto abaixo no seu arquivo README.md)
Markdown

# Sistema de Celulares em .NET (Desafio de POO)

![.NET](https://img.shields.io/badge/.NET-8.0-purple?logo=dotnet&style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-11.0-blue?logo=c-sharp&style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)

## 📝 Descrição do Projeto

Este projeto foi desenvolvido como uma solução para um desafio de programação que pedia a modelagem de um sistema de celulares. O objetivo principal é demonstrar a aplicação de conceitos fundamentais da **Programação Orientada a Objetos (POO)** para criar um código flexível, reutilizável e de fácil manutenção.

Através de uma classe abstrata `Celular`, o sistema define um "contrato" comum para todos os celulares. Classes concretas como `Iphone` e `Samsung` herdam desse contrato e implementam seus comportamentos específicos, mostrando como diferentes objetos podem responder de maneiras únicas à mesma ação.

## 🚀 Conceitos de POO Aplicados

Este projeto é um laboratório prático dos seguintes pilares da Orientação a Objetos:

* **Abstração:** A classe `Celular.cs` é abstrata e define os atributos e métodos essenciais que todo celular deve possuir, sem se preocupar com os detalhes de implementação de cada marca.
* **Herança:** As classes `Iphone` e `Samsung` herdam de `Celular`, reutilizando os métodos comuns (como `Ligar()` e `Desligar()`) e evitando a duplicação de código.
* **Polimorfismo:** Métodos como `FazerLigacao()` e `TirarFoto()` são definidos na classe abstrata e sobrescritos (`override`) nas classes filhas, permitindo que cada marca execute a ação de uma maneira particular.
* **Encapsulamento:** Atributos como `_ligado` são protegidos (`protected`), garantindo que o estado interno do objeto só possa ser modificado através dos métodos públicos da classe (`Ligar()` e `Desligar()`), protegendo a integridade dos dados.

## 📂 Estrutura do Projeto

O código está organizado da seguinte forma para promover a clareza e a separação de responsabilidades:

/SistemaCelular
|
├── Celular.cs       # Classe abstrata base com o contrato do celular.
├── Iphone.cs        # Classe concreta que representa um iPhone.
├── Samsung.cs       # Classe concreta que representa um Samsung.
└── Program.cs       # Ponto de entrada da aplicação, onde os objetos são criados e testados.


## 💻 Como Executar

Para rodar este projeto em sua máquina local, siga os passos abaixo.

### Pré-requisitos

* [.NET SDK 8.0](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0) ou superior instalado.

### Passo a passo

1.  Clone o repositório para sua máquina:
    ```bash
    git clone [https://github.com/alvaro5801/SistemaCelular.git](https://github.com/alvaro5801/SistemaCelular.git)
    ```

2.  Navegue até o diretório do projeto:
    ```bash
    cd SistemaCelular
    ```

3.  Execute a aplicação:
    ```bash
    dotnet run
    ```

## 📜 Exemplo de Saída

Ao executar o projeto, você verá a seguinte saída no console, demonstrando o comportamento polimórfico de cada objeto:

```console
### Testando o iPhone ###
O iPhone 15 Pro está ligando...
--- Informações do Celular ---
Marca: Apple
Modelo: iPhone 15 Pro
Armazenamento: 256GB
Status: Ligado
-----------------------------
iPhone: Ligando para 99999-1111 com o som característico 'bip bip'.
iPhone: Foto capturada com o sistema de câmera TrueDepth. *click*
Ouvindo... 'E aí, Siri?'
O iPhone 15 Pro está desligando...


### Testando o Samsung ###
O Galaxy S23 Ultra está ligando...
--- Informações do Celular ---
Marca: Samsung
Modelo: Galaxy S23 Ultra
Armazenamento: 512GB
Status: Ligado
-----------------------------
Samsung: Enviando SMS para 88888-2222: 'Olá, tudo bem?'
Samsung: Foto tirada com o 'Space Zoom'. Qualidade aprimorada por IA.
Modo DeX ativado. Transformando seu celular em um desktop.
O Galaxy S23 Ultra está desligando...
💡 Próximos Passos (Possíveis Melhorias)
[ ] Adicionar novas classes para outras marcas (ex: Motorola, Xiaomi).

[ ] Incluir mais propriedades nos celulares (nível de bateria, cor, tamanho da tela).

[ ] Implementar um sistema de instalação de aplicativos.

[ ] Criar testes unitários para validar o comportamento de cada classe.

[ ] Transformar a aplicação de console em uma API Web.

👨‍💻 Autor
Álvaro - alvaro5801

📄 Licença
Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

```

 
