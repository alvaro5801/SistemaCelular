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
