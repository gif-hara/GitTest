using UnityEngine;
using UnityEngine.Assertions;

namespace GitTest
{
    public sealed class aaa : MonoBehaviour
    {
        int Add(int a, int b)
        {
            return a + b;
        }
        int Division(int a, int b)
        {
            return a / b;
        }
        int Sub(int a, int b)
        {
            return a - b;
        }
        int Multi(int a, int b)
        {
            return a * b;
        }
        int Hoge(int a, int b)
        {
            return this.Add(a, b) + this.Sub(a, b);
        }
        int Fuga(int a, int b)
        {
            return this.Multi(a, b) + this.Division(a, b);
        }
        int Nyao(int a, int b)
        {
            return this.Hoge(a, b) + this.Fuga(a, b);
        }
        int Waon(int a, int b)
        {
            return this.Fuga(a, b) + this.Nyao(a, b);
        }
        int Cherry(int a, int b)
        {
            return this.Nyao(a, b) + this.Waon(a, b);
        }
        int Pick(int a, int b)
        {
            return this.Waon(a, b) + this.Cherry(a, b);
        }
    }
}
