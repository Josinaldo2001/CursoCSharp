using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},
                
                //estrutura de controle
                {"If - Estrutura de controle", EstruturaIf.Executar},
                {"If/Else - Estrutura de controle", EstruturaIfElse.Executar},
                {"If/ElseIf - Estrutura de controle", EstruturaIfElseIf.Executar},
                {"Switch - Estrutura de controle", EstruturaSwitch.Executar},
                {"While - Estrutura de controle", EstruturaWhile.Executar},
                {"Do While - Estrutura de controle", EstruturaDoWhile.Executar},
                {"For - Estrutura de controle", EstruturaFor.Executar},
                {"ForEach - Estrutura de controle", EstruturaForEach.Executar},

                //Classes e métodos

                {"Desafio Atributo - Classes e métodos", DesafioAtributo.Executar},
                {"Membros - Classes e métodos", Membros.Executar},
                {"Contrutores - Classes e métodos", Construtores.Executar},
                {"Métodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Métodos estáticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Parâmetros Variáveis - Classes e métodos", ParametrosVariaveis.Executar},
                {"Parâmetros nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"GettersSeters - Classes e métodos", GettersSeters.Executar},
                {"Props - Classes e métodos", Props.Executar},
                {"ReadOnly - Classes e métodos", ReadOnly.Executar},
                {"Ennum - Classes e métodos", ExemploEnum.Executar},
                {"Struct - Classes e métodos", Struct.Executar},
                //{"Pessoa", Pessoa.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}