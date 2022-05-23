using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    [SerializeField] public double a = 427.53f;
    double n1,n2,n3,n4,n5,n6,m1,m2,m3,m4,m5,m6;

    void Start()
    {
        print($"Valor: {a}");
        if(a>=100){
            n1 = (a - a % 100)/100;
            a = a % 100;
            print($"{n1} nota(s) de R$ 100,00");
        }
        if (a>=50){
            n2 = (a - a % 50)/50;
            a = a % 50;
            print($"{n2} nota(s) de R$ 50,00");
        }
        if (a>=20){
            n3 = (a - a % 20)/20;
            a = a % 20;
            print($"{n3} nota(s) de R$ 20,00");
        }
        if (a>=10){
            n4 = (a - a % 10)/10;
            a = a % 10;
            print($"{n4} nota(s) de R$ 10,00");
        }
        if (a>=5){
            n5 = (a - a % 5)/5;
            a = a % 5;
            print($"{n5} nota(s) de R$ 5,00");
        }
        if (a>=2){
            n6 = (a - a % 2)/2;
            a = a % 2;
            print($"{n6} nota(s) de R$ 2,00");
        }
        if (a>=1){
            m1 = (a - a % 1)/1;
            a = a % 1;
            print($"{m1} moeda(s) de R$ 1,00");
        }
        if (a>=0.50){
            m2 = (a - a % 0.5)/0.5;
            a = a % 0.5;
            print($"{m2} moeda(s) de R$ 0,50");
        }
        if (a>=0.25){
            m3 = (a - a % 0.25)/0.25;
            a = a % 0.25;
            print($"{m3} moeda(s) de R$ 0,25");
        }
        if (a>=0.10){
            m4 = (a - a % 0.10)/0.10;
            a = a % 0.10;
            print($"{m4} moeda(s) de R$ 0,10");
        }
        if (a>=0.05){
            m5 = (a - a % 0.05)/0.05;   
            a = a % 0.05;
            print($"{m5} moeda(s) de R$ 0,05");
        }
        if (a>0.01){
            m6 = (a - a % 0.01)/0.01;
            print("Troco em balas");   
        }
        if (a == 0){
            print("Digite um valor maior que 0");
        }
    }
}


