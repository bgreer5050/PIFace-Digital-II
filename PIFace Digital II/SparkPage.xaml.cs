using SPI_GPIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PIFace_Digital_II
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SparkPage : Page
    {
        public SparkPage()
        {
            this.InitializeComponent();
            InitAll();
        }

        private async void InitAll()
        {
            try
            {
                await MCP23S17.InitSPI();

                MCP23S17.InitMCP23S17();
                MCP23S17.setPinMode(0x00FF); // 0x0000 = all outputs, 0xffff=all inputs, 0x00FF is PIFace Default
                MCP23S17.pullupMode(0x00FF); // 0x0000 = no pullups, 0xffff=all pullups, 0x00FF is PIFace Default
                MCP23S17.WriteWord(0x0000); // 0x0000 = no pullups, 0xffff=all pullups, 0x00FF is PIFace Default
            }
            catch
            {

            }
         }


        private void LED7_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED7, 0);
        }

        private void LED7_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED7, 1);
        }

        private void LED6_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED6, 1);
        }

        private void LED6_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED6, 0);
        }

        private void LED5_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED5, 1);
        }

        private void LED5_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED5, 0);
        }

        private void LED4_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED4, 0);
        }

        private void LED4_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED4, 1);
        }

        private void LED3_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED3, 1);
        }

        private void LED3_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED3, 0);
        }

        private void LED2_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED2, 1);
        }

        private void LED2_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED2, 0);
        }

        private void LED1_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED1, 1);
        }

        private void LED1_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED1, 0);
        }

        private void LED0_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED0, 1);
        }

        private void LED0_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.LED0, 0);
        }

        //Note RelayA = R1, RelayB = R0
        private void RelayA_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.RelayB, 1);
            RelayAImage.Source = RelayOn.Source;
            LED1.IsChecked = true;
        }

        private void RelayB_Checked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.RelayB, 1);
            RelayBImage.Source = RelayOn.Source;
            LED0.IsChecked = true; ;
        }

        private void RelayA_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.RelayB, 0);
            RelayAImage.Source = RelayOff.Source;
            LED1.IsChecked = false; ;
        }

        private void RelayB_Unchecked(object sender, RoutedEventArgs e)
        {
            MCP23S17.WritePin(PFDII.RelayB, 0);
            RelayBImage.Source = RelayOff.Source;
            LED0.IsChecked = false; ;
        }

    }
}
