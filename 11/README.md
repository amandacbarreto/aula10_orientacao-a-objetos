# Aula 11 - Controladores de acesso

## Resumo do conte�do da aula

### Sintaxe


#### Modificador de classe / Controlador de acesso

**Modificador Classe:** Define a visibilidade/comportamento da Classe.

**Controlador de Acesso:** Especifica em que momento* um membro da Classe poder� ser acess�vel.

**Nota:** Membros = atributos e m�todos.

```cs

[Modificador Classe] class Lampada
{

    [Controlador de Acesso] string Fabricante = { get; set; };

    [Controlador de Acesso] virtual bool LigarOuDesligar()
    {

    }
}

```

### Lista de modificadores de visibilidade/comportamento da classe

**public**: Sem restri��es de visibilidade.

**abstract**: Classe-base para outras classes, n�o podem ser inst�nciadas.

**sealed**: Classe n�o permite heran�a.

**static**: Classe pode ser utilizanda sem a necessidade de inst�nci�-la.


### Lista de controladores de acesso dos membros da classe

**public**: Sem restri��o de acesso.

**private**: S� podem ser acessados pela pr�pria classe.

**protected**: Podem ser acessados pela pr�pria classe e por classes derivadas/herdeiras.

**virtual**: Permite que o m�todo possa ser redefinido por classes derivadas/herdeiras.

**static**: Permite que os membros da classe possam ser acessados sem a necessidade de inst�nciar a classe.


## Materiais de apoio

- Atividades
    - [Mesa de trabalho]()
- Atividades resolvidas (Professor)
	- [Mesa de trabalho]()
- Atividade resolvida (Alunos)
	- [Mesa de trabalho](./ENTREGA.md)