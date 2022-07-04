// See https://aka.ms/new-console-template for more information

bool IsPower2(int val){
    return ((val) & (val-1)) == 0;
}

System.Console.WriteLine(IsPower2(33));