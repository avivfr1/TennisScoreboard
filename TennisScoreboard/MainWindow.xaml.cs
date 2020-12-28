using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TennisScoreboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static ScoreLogic.TennisScoreBoardPoints tsbp;
        public MainWindow()
        {
            InitializeComponent();
            tsbp = new ScoreLogic.TennisScoreBoardPoints();
        }

        private void ButtonPlayerOne_Click(object sender, RoutedEventArgs e)
        {
            tsbp = ScoreLogic.CalcScore(tsbp, true);
            updateScoreBoard(tsbp);
        }

        private void ButtonPlayerTwo_Click(object sender, RoutedEventArgs e)
        {
            tsbp = ScoreLogic.CalcScore(tsbp, false);
            updateScoreBoard(tsbp);
        }

        internal void updateScoreBoard(ScoreLogic.TennisScoreBoardPoints tsbp)
        {
            TextBoxGameScoreOne.Text = tsbp.playerOneGameScore;
            TextBoxGameScoreTwo.Text = tsbp.playerTwoGameScore;
            TextBoxSetScoreOne.Text = tsbp.playerOneSetScore;
            TextBoxSetScoreTwo.Text = tsbp.playerTwoSetScore;
            TextBoxMatchScoreOne.Text = tsbp.playerOneMatchScore;
            TextBoxMatchScoreTwo.Text = tsbp.playerTwoMatchScore;
            TextBoxReferee.Text = tsbp.refereeAnnouncement;

            if (TextBoxReferee.Text.Contains("match"))
            {
                MessageBoxResult result = MessageBox.Show("Would you like to restart the match?", "Restart", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        ResetScoreBoard();
                        updateScoreBoard(tsbp);
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("See you next time!");
                        Application.Current.Shutdown();
                        break;
                }
            }
        }

        internal static void ResetScoreBoard()
        {
            tsbp.playerOneGameScore = "0";
            tsbp.playerTwoGameScore = "0";
            tsbp.playerOneSetScore = "0";
            tsbp.playerTwoSetScore = "0";
            tsbp.playerOneMatchScore = "0";
            tsbp.playerTwoMatchScore = "0";
            tsbp.refereeAnnouncement = "";
        }
    }
}
