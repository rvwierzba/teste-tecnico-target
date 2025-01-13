# Desafios Técnicos em C#

Este repositório contém as soluções desenvolvidas em **C#** para os desafios técnicos propostos.

## Desafios
 
git clone https://github.com/rvwierzba/teste-tecnico-target.git

Acesse a pasta do projeto:

cd teste-tecnico-target

Compile e execute o programa desejado:

    dotnet run


Requisitos

    .NET 5 ou superior
    Editor de código recomendado: Visual Studio ou Visual Studio Code

Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
Autor

Desenvolvido Rafael V. Wierzba


# Desafios Técnicos em C#

Este repositório contém soluções para desafios técnicos desenvolvidos em **C#**. Os desafios abordam lógica de programação e análise de dados, explorando diferentes conceitos fundamentais.

---

## 📋 Desafios

### 1️⃣ Soma de Índices
Dado o trecho de código:
```csharp
int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça {
    K = K + 1;
    SOMA = SOMA + K;
}
Imprimir(SOMA);

O programa calcula o valor final da variável SOMA.

Resultado esperado: 91

    Arquivo: SomaDeIndices.cs

2️⃣ Verificação de número na sequência de Fibonacci

O programa verifica se um número informado pertence à sequência de Fibonacci.
Detalhes:

    Entrada: Número inteiro fornecido pelo usuário.
    Saída: Mensagem indicando se o número pertence ou não à sequência.

Exemplo de uso:

Informe um número para verificar: 8
O número 8 pertence à sequência de Fibonacci.

    Arquivo: Fibonacci.cs

3️⃣ Faturamento diário de uma distribuidora

O programa analisa um vetor de faturamento diário e retorna:

    Menor valor de faturamento ocorrido em um dia do mês;
    Maior valor de faturamento ocorrido em um dia do mês;
    Número de dias em que o faturamento diário foi superior à média mensal.

Detalhes:

    Entrada: Um arquivo JSON contendo os valores de faturamento.
    Saída: Os resultados do cálculo acima.

Exemplo de entrada (faturamento.json):

[1000, 2000, 0, 3000, 4000, 0, 5000]

    Arquivo: FaturamentoDiario.cs

4️⃣ Percentual de representação de faturamento por estado

Com base no faturamento mensal por estado:

    SP: R$67.836,43
    RJ: R$36.678,66
    MG: R$29.229,88
    ES: R$27.165,48
    Outros: R$19.849,53

O programa calcula o percentual de representação de cada estado em relação ao total mensal.
Exemplo de saída:

Percentual de SP: 37,53%
Percentual de RJ: 20,28%
Percentual de MG: 16,19%
Percentual de ES: 15,04%
Percentual de Outros: 11,97%

    Arquivo: PercentualPorEstado.cs

5️⃣ Inversão de string

O programa inverte os caracteres de uma string fornecida pelo usuário, sem usar funções prontas como Reverse.
Detalhes:

    Entrada: Uma string informada pelo usuário.
    Saída: A string invertida.

Exemplo de uso:

Informe uma string: ZapPilot
String invertida: toliPpaZ

    Arquivo: InverterString.cs

🚀 Como Executar

    Pré-requisitos:
        Instale o .NET SDK 5 ou superior.
        Configure um editor de sua escolha, como Visual Studio ou Visual Studio Code.

    Clone o repositório:

git clone https://github.com/rvwierzba/desafio-tecnico-target.git

Acesse o diretório do repositório:

cd teste-tecnico-target/0-NOME-DO-PROJETO

Compile e execute o programa desejado:

    dotnet run --project Program.cs

🗂 Estrutura do Repositório

teste-tecnico-target/
├── 1-valor-variavel-soma/Program.cs        # Desafio 1
├── 2-sequencia-fibonacci/Program.cs        # Desafio 2
├── 3-faturamento-diario/Program.cs         # Desafio 3
├── 4-percentual-por-estado/Program.cs      # Desafio 4
├── 5-inverter-string/Program.cs            # Desafio 5
├── faturamento.json/Program.cs             # Arquivo de exemplo para o desafio 3
└── README.md                               # Documentação do repositório

📊 Dados de Entrada

    Desafio 3: Certifique-se de incluir o arquivo faturamento.json no formato especificado.
    Outros desafios possuem entradas via console, solicitadas diretamente ao usuário.

📝 Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo LICENSE para mais informações.
✒️ Autor

Desenvolvido por Seu Nome.

Se tiver dúvidas ou sugestões, sinta-se à vontade para abrir uma issue no repositório.

Espero que este README seja útil para você! Caso precise de ajuda para subir ao GitHub, é só avisar. 😊