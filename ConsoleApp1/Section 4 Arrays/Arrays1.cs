using System.Globalization;
using System.Threading.Channels;
using System.Collections.Generic;

namespace ConsoleApp1.Section_4_Arrays;

public static class Arrays1
{
    public static void Application()
    {
        // var postLiker = new fbPostLiker();
        // postLiker.StartLikeMachine();
        // var letsReversIt = new NameReverser();
        // letsReversIt.ReverseName();
        // var sortNumbers = new NumberSorter();
        // sortNumbers.play();
        // var unique = new UniqueNums();
        // unique.getNumbers();
        var lowest3 = new LowestThreeNumbers();
        LowestThreeNumbers.AskForNumbers();
        
    }
}