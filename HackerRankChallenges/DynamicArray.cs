using System.Net;

class DynamicArray
{
    public static void Initialize()
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);


        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = ProcessList(n, queries);

        //--Uncomment for using sample data
        //List<List<int>> queries = queries = FillList();
        //List<int> result = ProcessList(100, queries);
    }



    public static List<int> ProcessList(int n, List<List<int>> queries)
    {
        List<int> lstAnswers = new List<int>();
        List<List<int>> lstTemp = new List<List<int>>();

        for(int z = 0;z < n; z++)
            lstTemp.Add(new List<int>());

        int lastAnswer = 0;
        int x = 0, y = 0, type = 0;

        foreach (List<int> query in queries)
        {
            type = query[0];
            x = query[1];
            y = query[2];

            int idx = (x ^ lastAnswer) % n;

            if (type == 1)
                lstTemp[idx].Add(y);
            else if (type == 2)
            {
                lastAnswer = lstTemp[idx][y % (lstTemp[idx].Count)];
                lstAnswers.Add(lastAnswer);
            }
        }
        return lstAnswers;
    }


    private static List<List<int>> FillList()
    {
        List<List<int>> queries = new List<List<int>>();
        queries.Add(new List<int>() {1, 345255357,	 205970905 });
        queries.Add(new List<int>() {1, 570256166,	 75865401 });
        queries.Add(new List<int>() {1, 94777800 ,	645102173 });
        queries.Add(new List<int>() {1, 227496730,	 16649450 });
        queries.Add(new List<int>() {1, 82987157 ,	486734305 });
        queries.Add(new List<int>() {1, 917920354,	 757848208 });
        queries.Add(new List<int>() {1, 61379773 ,	817694251 });
        queries.Add(new List<int>() {1, 330547128,	 112869154 });
        queries.Add(new List<int>() {1, 328743001,	 855677723 });
        queries.Add(new List<int>() {1, 407951306,	 669798718 });
        queries.Add(new List<int>() {1, 21506172 ,	676980108 });
        queries.Add(new List<int>() {1, 49911390 ,	342109400 });
        queries.Add(new List<int>() {1, 980306253,	 305632965 });
        queries.Add(new List<int>() {2, 736380701,	 402184046 });
        queries.Add(new List<int>() {2, 798108301,	 416334323 });
        queries.Add(new List<int>() {1, 254839279,	 1370035 });
        queries.Add(new List<int>() {1, 109701362,	 2800586 });
        queries.Add(new List<int>() {1, 374257441,	 165208824 });
        queries.Add(new List<int>() {1, 624259835,	 477431250 });
        queries.Add(new List<int>() {1, 629066664,	 454406245 });
        queries.Add(new List<int>() {1, 135821145,	 763845832 });
        queries.Add(new List<int>() {1, 480298791,	 138234911 });
        queries.Add(new List<int>() {1, 553575409,	 835718837 });
        queries.Add(new List<int>() {1, 13022848 ,	624652920 });
        queries.Add(new List<int>() {1, 974893519,	 882630870 });
        queries.Add(new List<int>() {1, 137832930,	 216177975 });
        queries.Add(new List<int>() {1, 453349691,	 969255659 });
        queries.Add(new List<int>() {1, 138396076,	 91038209 });
        queries.Add(new List<int>() {1, 699822497,	 941751038 });
        queries.Add(new List<int>() {1, 116800806,	 64071662 });
        queries.Add(new List<int>() {1, 815273934,	 8835809 });
        queries.Add(new List<int>() {1, 658534867,	 657771609 });
        queries.Add(new List<int>() {1, 183760807,	 179377441 });
        queries.Add(new List<int>() {1, 93984556 ,	636425656 });
        queries.Add(new List<int>() {1, 231506463,	 836238924 });
        queries.Add(new List<int>() {1, 214074594,	 709571211 });
        queries.Add(new List<int>() {1, 649641434,	 509698468 });
        queries.Add(new List<int>() {2, 523656673,	 709717705 });
        queries.Add(new List<int>() {2, 261443586,	 330808140 });
        queries.Add(new List<int>() {1, 75924023 ,	449768243 });
        queries.Add(new List<int>() {1, 849537714,	 354568873 });
        queries.Add(new List<int>() {2, 641743742,	 124196560 });
        queries.Add(new List<int>() {1, 19829224 ,	995759639 });
        queries.Add(new List<int>() {1, 244389335,	 108315212 });
        queries.Add(new List<int>() {1, 877758467,	 421383626 });
        queries.Add(new List<int>() {1, 573278148,	 474192994 });
        queries.Add(new List<int>() {2, 561031511,	 448889978 });
        queries.Add(new List<int>() {1, 773294404,	 980994962 });
        queries.Add(new List<int>() {2, 33088709 ,	716646168 });
        queries.Add(new List<int>() {1, 760927835,	 441983538 });
        queries.Add(new List<int>() {1, 273540687,	 783321829 });
        queries.Add(new List<int>() {1, 59338453,	84358662 });
        queries.Add(new List<int>() {1, 543628702,	 372160176 });
        queries.Add(new List<int>() {2, 136400466,	 910559291 });
        queries.Add(new List<int>() {2, 546568738,	 393221347 });
        queries.Add(new List<int>() {1, 812227065,	 694221123 });
        queries.Add(new List<int>() {1, 311065574,	 103905420 });
        queries.Add(new List<int>() {2, 571344361,	 185289590 });
        queries.Add(new List<int>() {1, 99638520 ,	173318136 });
        queries.Add(new List<int>() {1, 854060080,	 407068012 });
        queries.Add(new List<int>() {2, 980658213,	 778573744 });
        queries.Add(new List<int>() {2, 412539660,	 476853104 });
        queries.Add(new List<int>() {1, 530145366,	 36493537 });
        queries.Add(new List<int>() {1, 604875364,	 100141497 });
        queries.Add(new List<int>() {2, 650812104,	 64817757 });
        queries.Add(new List<int>() {1, 141060009,	 766603553 });
        queries.Add(new List<int>() {1, 598398952,	 418245941 });
        queries.Add(new List<int>() {1, 262344011,	 431865586 });
        queries.Add(new List<int>() {2, 56413893 ,	546484833 });
        queries.Add(new List<int>() {1, 400736735,	 673588153 });
        queries.Add(new List<int>() {1, 642955232,	 803851098 });
        queries.Add(new List<int>() {1, 917782037,	 935143105 });
        queries.Add(new List<int>() {1, 658284524,	 745224102 });
        queries.Add(new List<int>() {1, 103202288,	 501551287 });
        queries.Add(new List<int>() {1, 162144918,	 12888783 });
        queries.Add(new List<int>() {1, 16486753 ,	67467208 });
        queries.Add(new List<int>() {1, 671120703,	 941541277 });
        queries.Add(new List<int>() {1, 47399694 ,	77707668 });
        queries.Add(new List<int>() {1, 122011395,	 946116527 });
        queries.Add(new List<int>() {1, 924363862,	 886726236 });
        queries.Add(new List<int>() {2, 657761235,	 540240467 });
        queries.Add(new List<int>() {1, 203175991,	 279882007 });
        queries.Add(new List<int>() {2, 304620923,	 162838413 });
        queries.Add(new List<int>() {1, 440453449,	 117964712 });
        queries.Add(new List<int>() {2, 941868853,	 887850334 });
        queries.Add(new List<int>() {1, 293198923,	 466812643 });
        queries.Add(new List<int>() {1, 461688477,	 532794906 });
        queries.Add(new List<int>() {1, 315016797,	 733095902 });
        queries.Add(new List<int>() {1, 265008751,	 913972757 });
        queries.Add(new List<int>() {1, 887405255,	 139170948 });
        queries.Add(new List<int>() {2, 754223230,	 426836947 });
        queries.Add(new List<int>() {1, 945967814,	 852589735 });
        queries.Add(new List<int>() {1, 168866283,	 309720694 });
        queries.Add(new List<int>() {1, 373861145,	 94596540 });
        queries.Add(new List<int>() {2, 984122495,	 20702849 });
        queries.Add(new List<int>() {2, 233835636,	 180460242 });
        queries.Add(new List<int>() {1, 172787631,	 643823473 });
        queries.Add(new List<int>() {1, 273611372,	 616819555 });
        queries.Add(new List<int>() {1, 196104599,	 690080895 });
        queries.Add(new List<int>() { 1, 527554061, 434103342 });
        return queries;
    }
}


//int lastAnswer = 0;

//List<int> answer;
//List<List<int>> queriesTemp = new List<List<int>>();
//List<int> ret = new List<int>(); ;

//for (int i = 0; i < n; i++)
//{
//    answer = new List<int>();
//    queriesTemp.Add(answer);
//}

//foreach (List<int> query in queries)
//{
//    int queryType = query[0];
//    int idx = (query[1] ^ lastAnswer) % n;

//    if (queryType == 1)
//    {
//        queriesTemp[idx].Add(query[2]);
//    }
//    else
//    {
//        var c = query[2] % queriesTemp[idx].Count;
//        lastAnswer = queriesTemp[idx][c];
//        ret.Add(lastAnswer);
//    }

//}
//return ret;