using GeradorDeEscalaGCM.Dominio;
using GeradorDeEscalaGCM.Dominio.Escala;
using GeradorDeEscalaGCM.Dominio.Escala.EscalaFinal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

string path = "C:\\Users\\edist\\OneDrive\\Desktop\\MapaForca.csv";
FileStream Fs = new FileStream(path, FileMode.Open, FileAccess.Read);
StreamReader Sr = new StreamReader(Fs);

Console.Write("Informe a unidade: "); //Disponibilizar uma lista suspensa baseada nas UGCMs
string UGCM = Console.ReadLine();

Efetivo.CriarServidores(Sr, UGCM);
Sr.Close();

Motorizado.CriarViatura();
Motorizado.MobiliarViaturas();
Armaria.MobiliarArmaria();
AssistenteTecnicoAdministrativo.MobiliarATA();
AssistenteTecnicoOperacional.MobiliarATO();
//AssistenteTecnicoOperacional.ImprimirATO();
//AssistenteTecnicoAdministrativo.ImprimirATA();
//Armaria.ImprimirArmeiros();
//Motorizado.ImprimirViaturas();
