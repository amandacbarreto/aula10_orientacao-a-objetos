# Aula 09 - Tratamento de Error

## Resumo do conte�do da aula


### Tratando uma Excess�o com `try`/`catch`/`finally`

```cs

try
{
    // For�amos o erro ao tentar dividir um valor inteiro por 0.
    int calculo = 10 / 0;

    Console.WriteLine(calculo);
} 
catch(Exception error)
{
    // No bloco de tratamento do erro capturamos...
    Console.WriteLine("C�digo do Error AbCd123");
    // Tipo do Erro nesse techo do c�digo.
    Console.WriteLine(error.GetType());
}
finally
{
    // Definimos uma instru��o que dever� ser executada ap�s o bloco try/catch.
    // Nota: Esse trecho de c�digo ser� executado independente de existir uma excess�o ou n�o.
    Console.WriteLine("Reinicie o programa...");
}

```

### Criando uma Excess�o com `throw`

```cs

int capturaDaIdadeDoUsuario = Console.ReadLine();

bool valorCapturadoForValido = int.TryParse(capturaDaIdadeDoUsuario, out idadeDoUsuario);

if(valorCapturadoForValido) {
    Console.WriteLine(idadeDoUsuario);
}
else {
    // Uma Excess�o � cadastrada para tratamento.
    throw new Exception("Valor inserido � inv�lido.");
}

```

## Materiais de apoio

- Atividades
    - [Mesa de trabalho](https://docs.google.com/document/d/1dtGLl0qcKBc-NdvUbwVNDUiCWPtVK8N0E1rbegRv7iE/edit?usp=sharing)
- Atividades resolvidas (Professor)
	- [Mesa de trabalho]()
- Atividade resolvida (Alunos)
	- [Mesa de trabalho](./ENTREGA.md)