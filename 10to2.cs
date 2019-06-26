public class binaryconvert
{
    public static void Main(string[] args)
    {
        int num = 0;
        // dec入力受け付け
        System.Console.Write("10進数を入力  ");
        num = int.Parse(System.Console.ReadLine());
        string bin = "";	// 結果の2進数を格納する文字列
    		// 繰り返し処理
    		do {
    			if ( 0 == ( num % 2 ) )
    				bin = "0" + bin;
    			else
    				bin = "1" + bin;
    			num = num / 2;
    		} while( 0 < num );
    
    		// 2進数を表示
    		System.Console.WriteLine( " 2進数：" + bin );

    }    
}

