using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthMe;
using ClipService;
using System.Diagnostics;

namespace WebApiExtensionsEtc
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            
           // AuthService myUser = new AuthService();
           //var token = await myUser.Authenticate("bob", "bob");
            
           // var clip = await FunnyClipService.GetClip(token);
           // var prs = new ProcessStartInfo("iexplore.exe");
           // prs.Arguments = clip;
           // Process.Start(clip);
           // System.Threading.Thread.Sleep(10000);
           // var x = await myUser.IsValidToken(token);

           // do
           // {

                
           //     if (x == true)
           //     {
           //         System.Threading.Thread.Sleep(10000);
           //         token = await myUser.RefreshToken(token);
           //         var clip2 = await FunnyClipService.GetClip(token);
           //         Process.Start(clip2);
                    
           //     }
           //     else
           //     {
           //         token = await myUser.RefreshToken(token);
           //         x = await myUser.IsValidToken(token);
           //     }
           // } while (true);
        }   
    }
}
