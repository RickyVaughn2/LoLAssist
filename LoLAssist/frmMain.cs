﻿using LoLAssist.StaticDataEndpoint;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LoLAssist
{
    public partial class frmMain : Form
    {
        private static Queue queue = Queue.RankedSolo5x5;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        //Get ID Button
        private void btnGetSummonerID_Click(object sender, EventArgs e)
        {
            string getSummonerID = txtSummonerName.Text;

            Chilkat.Http http = new Chilkat.Http();

            bool success;

            //  Any string unlocks the component for the 1st 30-days.
            success = http.UnlockComponent("RCKVGHHttp_AY8XA2SURK3o");
            if (success != true)
            {
                txtJSONReply.Text = http.LastErrorText;
                return;
            }

            //  Send the HTTP GET and return the content in a string.

            string html = "nothing";
            string jsonText = "/api/lol/" + GlobalVar.SummonerRegion + "/v1.4/summoner/by-name/" + getSummonerID;
            html = http.QuickGetStr("https://na.api.pvp.net" + jsonText + " ?api_key=" + GlobalVar.apiKey);
            //txtJSONReply.Text = html;

            //deserialize
            JObject json = JObject.Parse(html);

            GlobalVar.SummonerID = json.SelectToken(getSummonerID).SelectToken("id").ToString();
            GlobalVar.SummonerName = json.SelectToken(getSummonerID).SelectToken("name").ToString();
            GlobalVar.SummonerLevel = json.SelectToken(getSummonerID).SelectToken("summonerLevel").ToString();
            GlobalVar.SummonerIcon = json.SelectToken(getSummonerID).SelectToken("profileIconId").ToString();
            GlobalVar.SummonerRevisionDate = json.SelectToken(getSummonerID).SelectToken("revisionDate").ToString();

            lblSummonerID.Text = GlobalVar.SummonerID;

            txtJSONReply.Text = txtJSONReply.Text + "ID: " + GlobalVar.SummonerID + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Name: " + GlobalVar.SummonerName + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Level: " + GlobalVar.SummonerLevel + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Icon: " + GlobalVar.SummonerIcon + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Revision Date: " + GlobalVar.SummonerRevisionDate + Environment.NewLine;
        }

        //Get Ranked Info Button
        private void btnGetRankedInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDLLGetID_Click(object sender, EventArgs e)
        {
            var api = RiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb");
            var summoner = api.GetSummoner(LoLAssist.Region.na, "unseenhorror");
            lblSummonerID.Text = summoner.Id.ToString();
        }

        private void btnAnnieRange_Click(object sender, EventArgs e)
        {
            //string apiKey = RiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb").ToString();
            StaticRiotApi api = StaticRiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb");

            var champ = api.GetChampion(LoLAssist.Region.na, 1, ChampionData.all);

            txtJSONReply.Text = champ.Stats.AttackRange.ToString();
        }

        private void btnS4Kills_Click(object sender, EventArgs e)
        {
        }

        private void btnRecentGames_Click(object sender, EventArgs e)
        {
            var api = RiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb");
            var staticApi = StaticRiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb");

            var championIds = new List<int>();
            for (int i = 0; i < 30; i += 15)
            {
                var matches = api.GetMatchHistory(LoLAssist.Region.na, 20499334, i, i + 15, null,
                    new List<Queue>() { Queue.RankedSolo5x5 });
                foreach (var match in matches)
                {
                    championIds.Add(match.Participants[0].ChampionId);
                }
            }
            var mostPlayedChampId = championIds.GroupBy(c => c).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
            var mostPlayedChamp = staticApi.GetChampion(LoLAssist.Region.na, mostPlayedChampId);

            txtJSONReply.Text = mostPlayedChamp.Name;
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {

            


            //get the summoner name
            var summonerName = txtSummonerName.Text;
            //fire off our API key from Riot
            var api = RiotApi.GetInstance("ff7e1c46-b7d3-4251-a5f9-61f29495cdeb");
            //get our summoner id from the summoner name
            var summoner = api.GetSummoner(LoLAssist.Region.na, summonerName);
            //add the summoner name and id to the text box
            txtJSONReply.Text = txtJSONReply.Text + "Name: " + summoner.Name.ToString() + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "ID: " + summoner.Id.ToString() + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Level: " + summoner.Level.ToString() + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Icon: " + summoner.ProfileIconId.ToString() + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Region: " + summoner.Region.ToString() + Environment.NewLine;
            txtJSONReply.Text = txtJSONReply.Text + "Revision Date: " + summoner.RevisionDate.ToString() + Environment.NewLine;

            var matches = summoner.GetMatchHistory(0, 14, null, new List<Queue>() { queue });
            foreach (var match in matches)
            {
                txtJSONReply.Text = txtJSONReply.Text + "Match Type: " + match.MapType.ToString() + Environment.NewLine;
                txtJSONReply.Text = txtJSONReply.Text + "Match Duration: " + match.MatchDuration.ToString() + Environment.NewLine;
                txtJSONReply.Text = txtJSONReply.Text + "Match ID: " + match.MatchId.ToString() + Environment.NewLine;

                //var participants = match.Participants
                txtJSONReply.Text = txtJSONReply.Text + "Match Participants: " + match.Participants.ToString() + Environment.NewLine;
                
            }

            
        }
    }
}