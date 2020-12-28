using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoreboard
{
    class ScoreLogic
    {
        public static TennisScoreBoardPoints CalcScore(TennisScoreBoardPoints points, bool playerOne)
        {
            TennisScoreBoardPoints tsbp = points;
            tsbp.refereeAnnouncement = "";
            string returnedStr = "";

            if (playerOne)
            {
                returnedStr = ScoreLogic.PointScored(points.playerOneGameScore, points.playerTwoGameScore);
            }

            else
            {
                returnedStr = ScoreLogic.PointScored(points.playerTwoGameScore, points.playerOneGameScore);
            }

            if (returnedStr.Equals("Win!"))
            {
                tsbp.playerOneGameScore = "0";
                tsbp.playerTwoGameScore = "0";

                if (playerOne)
                {
                    returnedStr = ScoreLogic.GameScored(points.playerOneSetScore, points.playerTwoSetScore);
                }

                else
                {
                    returnedStr = ScoreLogic.GameScored(points.playerTwoSetScore, points.playerOneSetScore);
                }

                if (returnedStr.Equals("Win!"))
                {
                    tsbp.playerOneSetScore = "0";
                    tsbp.playerTwoSetScore = "0";

                    if (playerOne)
                    {
                        returnedStr = ScoreLogic.SetScored(points.playerOneMatchScore, points.playerTwoMatchScore);
                    }

                    else
                    {
                        returnedStr = ScoreLogic.SetScored(points.playerTwoMatchScore, points.playerOneMatchScore);
                    }

                    if (returnedStr.Equals("Win!"))
                    {
                        if (playerOne)
                        {
                            tsbp.playerOneMatchScore = (Int32.Parse(tsbp.playerOneMatchScore) + 1).ToString();
                        }

                        else
                        {
                            tsbp.playerTwoMatchScore = (Int32.Parse(tsbp.playerTwoMatchScore) + 1).ToString();
                        }
                        
                        tsbp.refereeAnnouncement = RefereeAnnouncement("match", playerOne);
                    }

                    else
                    {
                        tsbp.refereeAnnouncement = RefereeAnnouncement("set", playerOne);

                        if (playerOne)
                        {
                            tsbp.playerOneMatchScore = returnedStr.Split(',')[0];
                            tsbp.playerTwoMatchScore = returnedStr.Split(',')[1];
                        }

                        else
                        {
                            tsbp.playerOneMatchScore = returnedStr.Split(',')[1];
                            tsbp.playerTwoMatchScore = returnedStr.Split(',')[0];
                        }
                    }
                }

                else
                {
                    tsbp.refereeAnnouncement = RefereeAnnouncement("game", playerOne);

                    if (playerOne)
                    {
                        tsbp.playerOneSetScore = returnedStr.Split(',')[0];
                        tsbp.playerTwoSetScore = returnedStr.Split(',')[1];
                    }

                    else
                    {
                        tsbp.playerOneSetScore = returnedStr.Split(',')[1];
                        tsbp.playerTwoSetScore = returnedStr.Split(',')[0];
                    }
                }
            }

            else
            {
                if (playerOne)
                {
                    tsbp.playerOneGameScore = returnedStr.Split(',')[0];
                    tsbp.playerTwoGameScore = returnedStr.Split(',')[1];
                }

                else
                {
                    tsbp.playerOneGameScore = returnedStr.Split(',')[1];
                    tsbp.playerTwoGameScore = returnedStr.Split(',')[0];
                }
            }

            return tsbp;
        }

        public static string PointScored(string playerScoreWeCheck, string secondPlayerScore)
        {
            switch (playerScoreWeCheck)
            {
                case "0":
                    return "15," + secondPlayerScore;
                case "15":
                    return "30," + secondPlayerScore;
                case "30":
                    return "40," + secondPlayerScore;
                case "40":
                    if (CheckGameWin(playerScoreWeCheck, secondPlayerScore))
                    {
                        return "Win!";
                    }

                    else
                    {
                        if (secondPlayerScore.Equals("Adv"))
                        {
                            return "40,40";
                        }

                        else
                        {
                            return "Adv," + secondPlayerScore;
                        }
                    }
                case "Adv":
                    return "Win!";
                default:
                    return "";
            }
        }

        public static bool CheckGameWin(string playerScoreWeCheck, string secondPlayerScore)
        {
            if (playerScoreWeCheck.Equals("Adv"))
            {
                return true;
            }

            else if (playerScoreWeCheck.Equals("40") && secondPlayerScore.Equals("40"))
            {
                return false;
            }

            else if (playerScoreWeCheck.Equals("40") && !secondPlayerScore.Equals("Adv"))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static string GameScored(string playerNumberOfGamesWeCheckStr, string secondPlayerNumberOfGamesStr)
        {
            int playerNumberOfGamesWeCheck = Int32.Parse(playerNumberOfGamesWeCheckStr);
            int secondPlayerNumberOfGames = Int32.Parse(secondPlayerNumberOfGamesStr);
            playerNumberOfGamesWeCheck++;

            if (playerNumberOfGamesWeCheck == 7)
            {
                return "Win!";
            }

            else if (playerNumberOfGamesWeCheck == 6 && playerNumberOfGamesWeCheck - secondPlayerNumberOfGames >= 2)
            {
                return "Win!";
            }

            else
            {
                return playerNumberOfGamesWeCheck.ToString() + "," + secondPlayerNumberOfGamesStr;
            }
        }

        public static string SetScored(string playerNumberOfSetsWeCheckStr, string secondPlayerNumberOfSetsStr)
        {
            int playerNumberOfSetsWeCheck = Int32.Parse(playerNumberOfSetsWeCheckStr);
            int secondPlayerNumberOfSets = Int32.Parse(secondPlayerNumberOfSetsStr);
            playerNumberOfSetsWeCheck++;

            if (playerNumberOfSetsWeCheck == 2)
            {
                return "Win!";
            }

            else
            {
                return playerNumberOfSetsWeCheck.ToString() + "," + secondPlayerNumberOfSetsStr;
            }
        }

        public static string RefereeAnnouncement(string type, bool playerOne)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(playerOne ? "Player 1 " : "Player 2 ");

            switch(type)
            {
                case "game":
                    sb.Append("won a game!");
                    break;
                case "set":
                    sb.Append("won a set!");
                    break;
                case "match":
                    sb.Append("won the match!");
                    break;
                default:
                    sb.Clear();
                    break;
            }

            return sb.ToString();
        }

        public class TennisScoreBoardPoints
        {
            public string playerOneGameScore { get; set; }
            public string playerTwoGameScore { get; set; }
            public string playerOneSetScore { get; set; }
            public string playerTwoSetScore { get; set; }
            public string playerOneMatchScore { get; set; }
            public string playerTwoMatchScore { get; set; }
            public string refereeAnnouncement { get; set; }

            public TennisScoreBoardPoints()
            {
                playerOneGameScore = "0";
                playerTwoGameScore = "0";
                playerOneSetScore = "0";
                playerTwoSetScore = "0";
                playerOneMatchScore = "0";
                playerTwoMatchScore = "0";
                refereeAnnouncement = "";
            }
        }
    }
}
