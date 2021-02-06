using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace PressAndReleaseButton
{
    public partial class MainPage : ContentPage
    {
        bool animationlnProgress = false;
        Stopwatch stopwatch = new Stopwatch();

        public void PressAndReleaseButtonPage(){

            InitializeComponent();

        }

        void OnButtonPressed(object sender, EventArgs args){
            stopwatch.Start();
            animationlnProgress = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(16), () =>
            {
                label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);
                return animationlnProgress;
            });
        }

        void OnButtonReleased(object sender, EventArgs args){
            animationlnProgress = false;
            stopwatch.Stop();
        }
    }
}
