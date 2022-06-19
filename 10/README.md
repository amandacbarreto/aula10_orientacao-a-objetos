# Aula 10 - Introdu��o a Orienta��o a Objeto

## Resumo do conte�do da aula

### Encapsulamento

Agrupamos/Empasulamos em um contexto atributos e m�todos em uma classe. 

```cs

class Lampada
{
    // Propriedade p�blica - Vari�veis
    public string Fabricante = { get; set; };

    // M�todo Acess�vel/P�blico - Fun��es
    public virtual bool LigarOuDesligar()
    {

    }
}

```

### Abstra��o

Abstraimos/Privamos o acesso � atributos e m�todos a partir de controladores de acesso. 

```cs

class Lampada
{
    public string Fabricante = { get; set; };
    
    // Definimos propriedades que ser�o Abstra�das/Privados de acesso.
    private int Voltagem = 110;

        
    // Definimos m�todo que ser�o Abstra�dos/Privados de acesso.
    private void GerarRelatorioDeUso() { }

    public virtual bool LigarOuDesligar()
    {

    }
}

```

### Heran�a

Herdamos os atributos e m�todos implementados anteriormente, possibilitando o reaproveitando e implementa��o de novos recursos. 

```cs

class Lampada
{
    public string Fabricante = { get; set; };
    
    private int Voltagem = 110;

    private void GerarRelatorioDeUso() { }

    public virtual bool LigarOuDesligar()
    {

    }
}

// Herdamos os atributos e m�todos da classe Lampada.
class Hue : Lampada {

    public void VariarIluminosidade()
    {

    }
}

```

### Polimorfismo

A partir de uma Heran�a, podemos sobrescrever recursos da classe herdada, sobrescrevendo alguns recursos herdados.

```cs

class Lampada
{
    public string Fabricante = { get; set; };

    private int Voltagem = 110;

    private void GerarRelatorioDeUso() { }

    public virtual bool LigarOuDesligar()
    {

    }
}

class Hue : Lampada
{

    public void VariarIluminosidade()
    {

    }

    // Sobrescrevemos a funcionalidade de ligar/Desligar.
    public override bool LigarOuDesligar() {

    }
}

```

## Materiais de apoio

- Atividades
    - [Mesa de trabalho](https://docs.google.com/document/d/1MIkJer795YBaOznAwBMRvsBUMDNxWJJKymU_R49CoYk/edit?usp=sharing)
- Atividades resolvidas (Professor)
	- [Mesa de trabalho]()
- Atividade resolvida (Alunos)
	- [Mesa de trabalho](./ENTREGA.md)