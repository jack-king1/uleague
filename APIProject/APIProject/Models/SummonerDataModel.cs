using APIProject.Controllers;
using APIProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static APIProject.Models.MatchGameData;

namespace APIProject.Models
{
    public static class GlobalSummonerData
    {
        public static List<RuneData.RuneDataRoot> RuneData { get; set; }
        public static SummonerSpellData.Root SummonerSpellData { get; set; }
        public static List<MatchQueueType> matchQueueTypes { get; set; }
    }

    public class MatchQueueType
    {
        public int? queueId { get; set; }
        public string map { get; set; }
        public string description { get; set; }
        public string notes { get; set; }
    }

    public class SummonerData
    {
        public string id { get; set; }
        public string accountId { get; set; }
        public string puuid { get; set; }
        public string name { get; set; }
        public int? profileIconId { get; set; }
        public long? revisionDate { get; set; }
        public int? summonerLevel { get; set; }
    }

    public class MatchIDUsingpuuid
    {
        public List<string> MatchHistoryIDList { get; set; }
    }
    public class MatchGameData
    {
        public class Ban
    {
        public int? championId { get; set; }
        public int? pickTurn { get; set; }
    }

    public class Baron
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }

    public class Challenges
    {
        [JsonProperty("12AssistStreakCount")]
        public int? _12AssistStreakCount { get; set; }
        public int? abilityUses { get; set; }
        public int? acesBefore15Minutes { get; set; }
        public int? alliedJungleMonsterKills { get; set; }
        public int? baronBuffGoldAdvantageOverThreshold { get; set; }
        public int? baronTakedowns { get; set; }
        public int? blastConeOppositeOpponentCount { get; set; }
        public int? bountyGold { get; set; }
        public int? buffsStolen { get; set; }
        public int? completeSupportQuestInTime { get; set; }
        public double? controlWardTimeCoverageInRiverOrEnemyHalf { get; set; }
        public int? controlWardsPlaced { get; set; }
        public double? damagePerMinute { get; set; }
        public double? damageTakenOnTeamPercentage { get; set; }
        public int? dancedWithRiftHerald { get; set; }
        public int? deathsByEnemyChamps { get; set; }
        public int? dodgeSkillShotsSmallWindow { get; set; }
        public int? doubleAces { get; set; }
        public int? dragonTakedowns { get; set; }
        public double? earliestBaron { get; set; }
        public int? earlyLaningPhaseGoldExpAdvantage { get; set; }
        public double? effectiveHealAndShielding { get; set; }
        public int? elderDragonKillsWithOpposingSoul { get; set; }
        public int? elderDragonMultikills { get; set; }
        public int? enemyChampionImmobilizations { get; set; }
        public int? enemyJungleMonsterKills { get; set; }
        public int? epicMonsterKillsNearEnemyJungler { get; set; }
        public int? epicMonsterKillsWithin30SecondsOfSpawn { get; set; }
        public int? epicMonsterSteals { get; set; }
        public int? epicMonsterStolenWithoutSmite { get; set; }
        public double? firstTurretKilledTime { get; set; }
        public int? flawlessAces { get; set; }
        public int? fullTeamTakedown { get; set; }
        public double? gameLength { get; set; }
        public int? getTakedownsInAllLanesEarlyJungleAsLaner { get; set; }
        public double? goldPerMinute { get; set; }
        public int? hadOpenNexus { get; set; }
        public int? highestChampionDamage { get; set; }
        public int? immobilizeAndKillWithAlly { get; set; }
        public int? initialBuffCount { get; set; }
        public int? initialCrabCount { get; set; }
        public double? jungleCsBefore10Minutes { get; set; }
        public int? junglerTakedownsNearDamagedEpicMonster { get; set; }
        public int? kTurretsDestroyedBeforePlatesFall { get; set; }
        public double? kda { get; set; }
        public int? killAfterHiddenWithAlly { get; set; }
        public double? killParticipation { get; set; }
        public int? killedChampTookFullTeamDamageSurvived { get; set; }
        public int? killingSprees { get; set; }
        public int? killsNearEnemyTurret { get; set; }
        public int? killsOnOtherLanesEarlyJungleAsLaner { get; set; }
        public int? killsOnRecentlyHealedByAramPack { get; set; }
        public int? killsUnderOwnTurret { get; set; }
        public int? killsWithHelpFromEpicMonster { get; set; }
        public int? knockEnemyIntoTeamAndKill { get; set; }
        public int? landSkillShotsEarlyGame { get; set; }
        public int? laneMinionsFirst10Minutes { get; set; }
        public int? laningPhaseGoldExpAdvantage { get; set; }
        public int? legendaryCount { get; set; }
        public int? lostAnInhibitor { get; set; }
        public double? maxCsAdvantageOnLaneOpponent { get; set; }
        public int? maxKillDeficit { get; set; }
        public int? maxLevelLeadLaneOpponent { get; set; }
        public double? moreEnemyJungleThanOpponent { get; set; }
        public int? multiKillOneSpell { get; set; }
        public int? multiTurretRiftHeraldCount { get; set; }
        public int? multikills { get; set; }
        public int? multikillsAfterAggressiveFlash { get; set; }
        public int? mythicItemUsed { get; set; }
        public int? outerTurretExecutesBefore10Minutes { get; set; }
        public int? outnumberedKills { get; set; }
        public int? outnumberedNexusKill { get; set; }
        public int? perfectDragonSoulsTaken { get; set; }
        public int? perfectGame { get; set; }
        public int? pickKillWithAlly { get; set; }
        public int? playedChampSelectPosition { get; set; }
        public int? poroExplosions { get; set; }
        public int? quickCleanse { get; set; }
        public int? quickFirstTurret { get; set; }
        public int? quickSoloKills { get; set; }
        public int? riftHeraldTakedowns { get; set; }
        public int? saveAllyFromDeath { get; set; }
        public int? scuttleCrabKills { get; set; }
        public double? shortestTimeToAceFromFirstTakedown { get; set; }
        public int? skillshotsDodged { get; set; }
        public int? skillshotsHit { get; set; }
        public int? snowballsHit { get; set; }
        public int? soloBaronKills { get; set; }
        public int? soloKills { get; set; }
        public int? soloTurretsLategame { get; set; }
        public int? stealthWardsPlaced { get; set; }
        public int? survivedSingleDigitHpCount { get; set; }
        public int? survivedThreeImmobilizesInFight { get; set; }
        public int? takedownOnFirstTurret { get; set; }
        public int? takedowns { get; set; }
        public int? takedownsAfterGainingLevelAdvantage { get; set; }
        public int? takedownsBeforeJungleMinionSpawn { get; set; }
        public int? takedownsFirstXMinutes { get; set; }
        public int? takedownsInAlcove { get; set; }
        public int? takedownsInEnemyFountain { get; set; }
        public int? teamBaronKills { get; set; }
        public double? teamDamagePercentage { get; set; }
        public int? teamElderDragonKills { get; set; }
        public int? teamRiftHeraldKills { get; set; }
        public int? threeWardsOneSweeperCount { get; set; }
        public int? tookLargeDamageSurvived { get; set; }
        public int? turretPlatesTaken { get; set; }
        public int? turretTakedowns { get; set; }
        public int? turretsTakenWithRiftHerald { get; set; }
        public int? twentyMinionsIn3SecondsCount { get; set; }
        public int? unseenRecalls { get; set; }
        public double? visionScoreAdvantageLaneOpponent { get; set; }
        public double? visionScorePerMinute { get; set; }
        public int? wardTakedowns { get; set; }
        public int? wardTakedownsBefore20M { get; set; }
        public int? wardsGuarded { get; set; }
        public double? earliestDragonTakedown { get; set; }
        public int? junglerKillsEarlyJungle { get; set; }
        public int? killsOnLanersEarlyJungleAsJungler { get; set; }
        public int? fasterSupportQuestCompletion { get; set; }
        public double? fastestLegendary { get; set; }
        public int? highestWardKills { get; set; }
        public int? hadAfkTeammate { get; set; }
        public int? highestCrowdControlScore { get; set; }
    }

    public class Champion
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }

    public class Dragon
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }

    public class Info
    {
        public long? gameCreation { get; set; }
        public int? gameDuration { get; set; }
        public long? gameEndTimestamp { get; set; }
        public long? gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long? gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int? mapId { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public int? queueId { get; set; }
        public List<Team> teams { get; set; }
        public string tournamentCode { get; set; }
    }

    public class Inhibitor
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }

    public class Metadata
    {
        public string dataVersion { get; set; }
        public string matchId { get; set; }
        public List<string> participants { get; set; }
    }

    public class Objectives
    {
        public Baron baron { get; set; }
        public Champion champion { get; set; }
        public Dragon dragon { get; set; }
        public Inhibitor inhibitor { get; set; }
        public RiftHerald riftHerald { get; set; }
        public Tower tower { get; set; }
    }

    public class Participant
    {
        public int? allInPings { get; set; }
        public int? assistMePings { get; set; }
        public int? assists { get; set; }
        public int? baitPings { get; set; }
        public int? baronKills { get; set; }
        public int? basicPings { get; set; }
        public int? bountyLevel { get; set; }
        public Challenges challenges { get; set; }
        public int? champExperience { get; set; }
        public int? champLevel { get; set; }
        public int? championId { get; set; }
        public string championName { get; set; }
        public int? championTransform { get; set; }
        public int? commandPings { get; set; }
        public int? consumablesPurchased { get; set; }
        public int? damageDealtToBuildings { get; set; }
        public int? damageDealtToObjectives { get; set; }
        public int? damageDealtToTurrets { get; set; }
        public int? damageSelfMitigated { get; set; }
        public int? dangerPings { get; set; }
        public int? deaths { get; set; }
        public int? detectorWardsPlaced { get; set; }
        public int? doubleKills { get; set; }
        public int? dragonKills { get; set; }
        public bool? eligibleForProgression { get; set; }
        public int? enemyMissingPings { get; set; }
        public int? enemyVisionPings { get; set; }
        public bool? firstBloodAssist { get; set; }
        public bool? firstBloodKill { get; set; }
        public bool? firstTowerAssist { get; set; }
        public bool? firstTowerKill { get; set; }
        public bool? gameEndedInEarlySurrender { get; set; }
        public bool? gameEndedInSurrender { get; set; }
        public int? getBackPings { get; set; }
        public int? goldEarned { get; set; }
        public int? goldSpent { get; set; }
        public int? holdPings { get; set; }
        public string individualPosition { get; set; }
        public int? inhibitorKills { get; set; }
        public int? inhibitorTakedowns { get; set; }
        public int? inhibitorsLost { get; set; }
        public int? item0 { get; set; }
        public int? item1 { get; set; }
        public int? item2 { get; set; }
        public int? item3 { get; set; }
        public int? item4 { get; set; }
        public int? item5 { get; set; }
        public int? item6 { get; set; }
        public int? itemsPurchased { get; set; }
        public int? killingSprees { get; set; }
        public int? kills { get; set; }
        public string lane { get; set; }
        public int? largestCriticalStrike { get; set; }
        public int? largestKillingSpree { get; set; }
        public int? largestMultiKill { get; set; }
        public int? longestTimeSpentLiving { get; set; }
        public int? magicDamageDealt { get; set; }
        public int? magicDamageDealtToChampions { get; set; }
        public int? magicDamageTaken { get; set; }
        public int? needVisionPings { get; set; }
        public int? neutralMinionsKilled { get; set; }
        public int? nexusKills { get; set; }
        public int? nexusLost { get; set; }
        public int? nexusTakedowns { get; set; }
        public int? objectivesStolen { get; set; }
        public int? objectivesStolenAssists { get; set; }
        public int? onMyWayPings { get; set; }
        public int? participantId { get; set; }
        public int? pentaKills { get; set; }
        public Perks perks { get; set; }
        public int? physicalDamageDealt { get; set; }
        public int? physicalDamageDealtToChampions { get; set; }
        public int? physicalDamageTaken { get; set; }
        public int? profileIcon { get; set; }
        public int? pushPings { get; set; }
        public string puuid { get; set; }
        public int? quadraKills { get; set; }
        public string riotIdName { get; set; }
        public string riotIdTagline { get; set; }
        public string role { get; set; }
        public int? sightWardsBoughtInGame { get; set; }
        public int? spell1Casts { get; set; }
        public int? spell2Casts { get; set; }
        public int? spell3Casts { get; set; }
        public int? spell4Casts { get; set; }
        public int? summoner1Casts { get; set; }
        public int? summoner1Id { get; set; }
        public int? summoner2Casts { get; set; }
        public int? summoner2Id { get; set; }
        public string summonerId { get; set; }
        public int? summonerLevel { get; set; }
        public string summonerName { get; set; }
        public bool? teamEarlySurrendered { get; set; }
        public int? teamId { get; set; }
        public string teamPosition { get; set; }
        public int? timeCCingOthers { get; set; }
        public int? timePlayed { get; set; }
        public int? totalDamageDealt { get; set; }
        public int? totalDamageDealtToChampions { get; set; }
        public int? totalDamageShieldedOnTeammates { get; set; }
        public int? totalDamageTaken { get; set; }
        public int? totalHeal { get; set; }
        public int? totalHealsOnTeammates { get; set; }
        public int? totalMinionsKilled { get; set; }
        public int? totalTimeCCDealt { get; set; }
        public int? totalTimeSpentDead { get; set; }
        public int? totalUnitsHealed { get; set; }
        public int? tripleKills { get; set; }
        public int? trueDamageDealt { get; set; }
        public int? trueDamageDealtToChampions { get; set; }
        public int? trueDamageTaken { get; set; }
        public int? turretKills { get; set; }
        public int? turretTakedowns { get; set; }
        public int? turretsLost { get; set; }
        public int? unrealKills { get; set; }
        public int? visionClearedPings { get; set; }
        public int? visionScore { get; set; }
        public int? visionWardsBoughtInGame { get; set; }
        public int? wardsKilled { get; set; }
        public int? wardsPlaced { get; set; }
        public bool? win { get; set; }
    }

    public class Perks
    {
        public StatPerks statPerks { get; set; }
        public List<Style> styles { get; set; }
    }

    public class RiftHerald
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }

    public class RootGameData
    {
        public Metadata metadata { get; set; }
        public Info info { get; set; }
    }

    public class Selection
    {
        public int? perk { get; set; }
        public int? var1 { get; set; }
        public int? var2 { get; set; }
        public int? var3 { get; set; }
    }

    public class StatPerks
    {
        public int? defense { get; set; }
        public int? flex { get; set; }
        public int? offense { get; set; }
    }

    public class Style
    {
        public string description { get; set; }
        public List<Selection> selections { get; set; }
        public int? style { get; set; }
    }

    public class Team
    {
        public List<Ban> bans { get; set; }
        public Objectives objectives { get; set; }
        public int? teamId { get; set; }
        public bool? win { get; set; }
    }

    public class Tower
    {
        public bool? first { get; set; }
        public int? kills { get; set; }
    }
}
    public class KDA
    {
        public List<int> kills { get; set; }
        public List<int> deaths { get; set; }
        public List<int> assists { get; set; }
    }

    public class SummonerDataAll
    {
        public SummonerData data { get; set; }
        public string profileImgURL { get; set; }
        public List<RootGameData> matchGameDataList { get; set; }

        public List<Participant> playerMatchDataList { get; set; }

        public List<string> primaryRunePath { get; set; }
        public List<string> secondaryRunePath { get; set; }
        public List<string> summonerSpell1ImgPath { get; set; }
        public List<string> summonerSpell2ImgPath { get; set; }

        public List<int> gameLengthMinutes { get; set; }
        public List<int> gameLengthSeconds { get; set; }

        public List<string> gameType { get; set; }

        public List<string> sincePlayed {  get; set; }
        public List<string> didWin { get; set;  }
        public List<string> kdaRatio { get; set; }
        public KDA kda { get; set; }
        public List<string> killParticipationPercentage { get; set; }
        public List<int?> controlWardCount { get; set; }
        public List<string> creepScore { get; set; }
        public List<string> playerRank { get; set; }
        public List<List<int>> itemIDList { get; set; }

    }

    //a class to store all rune data from api e.g. domination, electrocute etc and all sub perks.
    public class RuneData
    {
        //Core Tree
        public class RuneDataRoot
        {
            public int? id { get; set; }
            public string key { get; set; }
            public string icon { get; set; }
            public string name { get; set; }
            public List<Slot> slots { get; set; }
        }

        //Keystones
        public class Rune
        {
            public int? id { get; set; }
            public string key { get; set; }
            public string icon { get; set; }
            public string name { get; set; }
            public string shortDesc { get; set; }
            public string longDesc { get; set; }
        }

        public class Slot
        {
            public List<Rune> runes { get; set; }
        }
    }


    //a class for all league spells e.g. flash, ignite
    public class SummonerSpellData
    {
        public class Data
        {
            public SummonerBarrier SummonerBarrier { get; set; }
            public SummonerBoost SummonerBoost { get; set; }
            public SummonerDot SummonerDot { get; set; }
            public SummonerExhaust SummonerExhaust { get; set; }
            public SummonerFlash SummonerFlash { get; set; }
            public SummonerHaste SummonerHaste { get; set; }
            public SummonerHeal SummonerHeal { get; set; }
            public SummonerMana SummonerMana { get; set; }
            public SummonerPoroRecall SummonerPoroRecall { get; set; }
            public SummonerPoroThrow SummonerPoroThrow { get; set; }
            public SummonerSmite SummonerSmite { get; set; }
            public SummonerSnowURFSnowballMark SummonerSnowURFSnowball_Mark { get; set; }
            public SummonerSnowball SummonerSnowball { get; set; }
            public SummonerTeleport SummonerTeleport { get; set; }
            public SummonerUltBookPlaceholder Summoner_UltBookPlaceholder { get; set; }
            public SummonerUltBookSmitePlaceholder Summoner_UltBookSmitePlaceholder { get; set; }
        }

        public class Datavalues
        {
        }

        public class Image
        {
            public string full { get; set; }
            public string sprite { get; set; }
            public string group { get; set; }
            public int? x { get; set; }
            public int? y { get; set; }
            public int? w { get; set; }
            public int? h { get; set; }
        }

        public class Root
        {
            public string type { get; set; }
            public string version { get; set; }
            public Data data { get; set; }
        }

        public class SummonerBarrier
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerBoost
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<double?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerDot
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerExhaust
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerFlash
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerHaste
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerHeal
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<double?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerMana
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerPoroRecall
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerPoroThrow
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerSmite
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerSnowball
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerSnowURFSnowballMark
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerTeleport
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerUltBookPlaceholder
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }

        public class SummonerUltBookSmitePlaceholder
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string tooltip { get; set; }
            public int? maxrank { get; set; }
            public List<int?> cooldown { get; set; }
            public string cooldownBurn { get; set; }
            public List<int?> cost { get; set; }
            public string costBurn { get; set; }
            public Datavalues datavalues { get; set; }
            public List<List<int?>> effect { get; set; }
            public List<string> effectBurn { get; set; }
            public List<object> vars { get; set; }
            public string key { get; set; }
            public int? summonerLevel { get; set; }
            public List<string> modes { get; set; }
            public string costType { get; set; }
            public string maxammo { get; set; }
            public List<int?> range { get; set; }
            public string rangeBurn { get; set; }
            public Image image { get; set; }
            public string resource { get; set; }
        }


    }

    public class SummonerDataModel
    {
        private string profileImgURL = "http://ddragon.leagueoflegends.com/cdn/13.8.1/img/profileicon/";

        [HttpPost]
        public async Task<dynamic> GetSummonrDataFromApiAsync(string summoner)
        {
            SummonerData summonerData = new SummonerData();
            List<string> ids = new List<string>();
            List<RootGameData> matchGameDataList = new List<RootGameData>();
            List<Participant> thisPlayersMatchData = new List<Participant>();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            //Check if global data is available
            if (GlobalSummonerData.SummonerSpellData == null || GlobalSummonerData.RuneData == null || GlobalSummonerData.matchQueueTypes == null)
            {
                GlobalSummonerData.SummonerSpellData = new SummonerSpellData.Root();
                GlobalSummonerData.RuneData = new List<RuneData.RuneDataRoot>();
                GlobalSummonerData.matchQueueTypes = new List<MatchQueueType>();
                #region SummonerSpell
                //Summoner Data
                dynamic jsonSummonerSpellData = await riotAPIService.GetSummonerSpellDataASync();
                try
                {
                    // ... process the retrieved data as needed ...
                    //GlobalSummonerData.SummonerSpellData = JObject.Parse(jsonSummonerSpellData).ToObject<SummonerSpellData.Root>();
                    GlobalSummonerData.SummonerSpellData = JsonConvert.DeserializeObject<SummonerSpellData.Root>(jsonSummonerSpellData);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
                #endregion
                #region RuneData
                //Rune Data
                dynamic jsonRuneData = await riotAPIService.GetRuneDataASync();
                try
                {
                    // ... process the retrieved data as needed ...
                    GlobalSummonerData.RuneData = JsonConvert.DeserializeObject<List<RuneData.RuneDataRoot>>(jsonRuneData);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
                #endregion

                #region MatchTypes
                //Rune Data
                dynamic jsonMatchTypeData = await riotAPIService.GetMatchTypeDataASync();
                try
                {
                    // ... process the retrieved data as needed ...
                    GlobalSummonerData.matchQueueTypes = JsonConvert.DeserializeObject<List<MatchQueueType>>(jsonMatchTypeData);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
                #endregion
            }

            // Call the API service method to retrieve data
            dynamic jsonSummonerInfo = await riotAPIService.GetSummonerDataByName(summoner);

            try
            {
                // ... process the retrieved data as needed ...
                summonerData = JObject.Parse(jsonSummonerInfo).ToObject<SummonerData>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            //Get match x20 history using PUUID
            dynamic jsonMatchInfo = await riotAPIService.GetSummonerMatchHistoryListByPuuid(summonerData.puuid);
            try
            {
                // ... process the retrieved data as needed ...
                ids = JsonConvert.DeserializeObject<List<string>>(jsonMatchInfo);
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            foreach (string matchDataID in ids)
            {
                dynamic matchDataJson = await riotAPIService.GetSummonerMatchDataByMatchID(matchDataID);
                try
                {
                    // ... process the retrieved data as needed ...
                    RootGameData md = new RootGameData();
                    md = JObject.Parse(matchDataJson).ToObject<RootGameData>();
                    matchGameDataList.Add(md);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
            //The active rune ids for searched player for each match.
            List<int?> primaryRuneListID = new List<int?>();
            List<int?> secondaryRuneListID = new List<int?>();
            //The active summoner spell ids for searched player for each match.
            List<int?> summonerSpell0List = new List<int?>();
            List<int?> summonerSpell1List = new List<int?>();

            SummonerDataAll package = new SummonerDataAll();
            package.data = summonerData;
            package.profileImgURL = profileImgURL + package.data.profileIconId + ".png";
            package.matchGameDataList = matchGameDataList;
            package.gameLengthMinutes = new List<int>();
            package.gameLengthSeconds = new List<int>();
            package.didWin = new List<string>();
            package.sincePlayed = new List<string>();
            package.gameType = new List<string>();
            package.kdaRatio = new List<string>();
            package.kda = new KDA();
            package.kda.kills = new List<int>();
            package.kda.deaths = new List<int>();
            package.kda.assists = new List<int>();
            package.killParticipationPercentage = new List<string>();
            package.controlWardCount = new List<int?>();
            package.creepScore = new List<string>();
            package.itemIDList = new List<List<int>>();
            int gameIncrementCount = 0;
            foreach (RootGameData rgd in package.matchGameDataList)
            {
                package.gameLengthSeconds.Add((int)(rgd.info.gameDuration % 60));
                package.gameLengthMinutes.Add((int)(rgd.info.gameDuration) / 60);
                string gameModeName = "Normal";
                //Game Type
                if(rgd.info.queueId == 420)
                {
                    gameModeName = "Ranked Solo";
                }
                else if(rgd.info.queueId == 440)
                {
                    gameModeName = "Ranked Flex";
                }
                else if (rgd.info.queueId == 450)
                {
                    gameModeName = "ARAM";
                }
                package.gameType.Add(gameModeName);


                //Days ago
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                .AddMilliseconds((double)rgd.info.gameEndTimestamp);

                // Calculate the time elapsed from the timestamp to now
                TimeSpan timeElapsed = DateTime.UtcNow - dt;

                // Extract the number of days from the time elapsed
                int daysAgo = (int)timeElapsed.TotalDays;
                int hoursAgo = 0;
                if(timeElapsed.TotalDays < 1)
                {
                    hoursAgo = (int)timeElapsed.TotalHours;
                }
                package.sincePlayed.Add((daysAgo == 0) ? $"{hoursAgo} hours ago" : $"{daysAgo} days ago");
                
                for (int i = 0; i < rgd.info.participants.Count; i++)
                {
                    if (rgd.info.participants[i].puuid == package.data.puuid)
                    {
                        thisPlayersMatchData.Add(rgd.info.participants[i]);
                        primaryRuneListID.Add(rgd.info.participants[i].perks.styles[0].selections[0].perk);
                        secondaryRuneListID.Add(rgd.info.participants[i].perks.styles[1].style);
                        summonerSpell0List.Add(rgd.info.participants[i].summoner1Id);
                        summonerSpell1List.Add(rgd.info.participants[i].summoner2Id);
                        package.didWin.Add((bool)(rgd.info.participants[i].win) ? "Victory" : "Defeat");
                        double kdaToNonNullable = (double)rgd.info.participants[i].challenges.kda;
                        string toFloatingPoinTwo = kdaToNonNullable.ToString("0.00");
                        package.kdaRatio.Add($"{toFloatingPoinTwo}:1 KDA");
                        package.kda.kills.Add((int)rgd.info.participants[i].kills);
                        package.kda.deaths.Add((int)rgd.info.participants[i].deaths);
                        package.kda.assists.Add((int)rgd.info.participants[i].assists);
                        if(rgd.info.participants[i].challenges.killParticipation != null)
                        {
                            double percentage = (double)rgd.info.participants[i].challenges.killParticipation;
                            string formattedPercentage = percentage.ToString("0%");
                            package.killParticipationPercentage.Add(formattedPercentage);
                        }
                        else
                        {
                            string formattedPercentage = "0%";
                            package.killParticipationPercentage.Add(formattedPercentage);
                        }
                        

                        package.controlWardCount.Add(rgd.info.participants[i].challenges.controlWardsPlaced);
                        float csPerMinute = (float)rgd.info.participants[i].totalMinionsKilled / (float)package.gameLengthMinutes[gameIncrementCount];
                        package.creepScore.Add($"CS {rgd.info.participants[i].totalMinionsKilled} ({csPerMinute.ToString("0.00")})");
                        //package.playerRank.Add($"")
                        //items
                        List<int> itemsToAdd = new List<int>();
                        #region riotapididntmakeitalist
                        if((int)rgd.info.participants[i].item0 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item0);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item1 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item1);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item2 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item2);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item3 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item3);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item4 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item4);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item5 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item5);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        if ((int)rgd.info.participants[i].item6 != 0)
                        {
                            itemsToAdd.Add((int)rgd.info.participants[i].item6);
                        }
                        else
                        {
                            itemsToAdd.Add(7050);
                        }
                        #endregion
                        package.itemIDList.Add(itemsToAdd);
                        break;
                    }
                }
                gameIncrementCount++;
            }

            package.secondaryRunePath = new List<string>();
            package.primaryRunePath = new List<string>();
            for (int primary = 0; primary < primaryRuneListID.Count; primary++)
            {
                foreach (RuneData.RuneDataRoot rd in GlobalSummonerData.RuneData)
                {
                    foreach (var rune in rd.slots[0].runes)
                    {
                        if (rune.id == primaryRuneListID[primary])
                        {
                            package.primaryRunePath.Add(rune.icon);
                        }
                    }

                    if (rd.id == secondaryRuneListID[primary])
                    {
                        package.secondaryRunePath.Add(rd.icon);
                    }
                }
            }

            package.summonerSpell1ImgPath = new List<string>();
            package.summonerSpell2ImgPath = new List<string>();
            SummonerSpellData.Data data = GlobalSummonerData.SummonerSpellData.data;
            for (int summonerSpellCount = 0; summonerSpellCount < summonerSpell0List.Count; summonerSpellCount++)
            {
                foreach (var component in new object[] { data.SummonerFlash, data.SummonerBarrier, data.SummonerBoost, data.SummonerDot, data.SummonerExhaust,
                data.SummonerMana, data.SummonerSmite, data.SummonerSnowball, data.SummonerHaste, data.SummonerHeal, data.Summoner_UltBookSmitePlaceholder,
                    data.Summoner_UltBookPlaceholder, data.SummonerPoroRecall, data.SummonerPoroThrow, data.SummonerTeleport, data.SummonerSnowURFSnowball_Mark,
                    data.SummonerHaste})
                {
                    bool matchingSpellID1 = false;
                    bool matchingSpellID2 = false;

                    foreach (var property in component.GetType().GetProperties())
                    {
                        if (property.Name == "key")
                        {
                            
                            int summonerID = int.Parse((string)property.GetValue(component));
                            if(summonerID == summonerSpell0List[summonerSpellCount])
                            {
                                matchingSpellID1 = true;
                            }
                            else if(summonerID == summonerSpell1List[summonerSpellCount])
                            {
                                matchingSpellID2 = true;
                            }
                        }
                        
                        if(!matchingSpellID1 && !matchingSpellID2)
                        {
                            continue;
                        }
                        
                        if(property.Name == "image")
                        {
                            SummonerSpellData.Image summonerSpellImage = (SummonerSpellData.Image)property.GetValue(component);
                            if(matchingSpellID1)
                            {
                                package.summonerSpell1ImgPath.Add(summonerSpellImage.full);
                            }
                            else
                            {
                                package.summonerSpell2ImgPath.Add(summonerSpellImage.full);
                            }
                        }
                    }
                }
            }


            package.playerMatchDataList = thisPlayersMatchData;

            // Return the processed dat   
            return package;
        }

        [HttpPost]
        public async Task<dynamic> GetSummonerSpellFromApiAsync()
        {
            SummonerSpellData.Data spellData = new SummonerSpellData.Data();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonSpellData = await riotAPIService.GetSummonerSpellDataASync();

            try
            {
                // ... process the retrieved data as needed ...
                spellData = JObject.Parse(jsonSpellData).ToObject<SummonerSpellData.Data>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            return spellData;
        }

        public async Task<dynamic> GetRuneDataFromApiAsync()
        {
            RuneData.RuneDataRoot runeData = new RuneData.RuneDataRoot();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonSpellData = await riotAPIService.GetRuneDataASync();


            try
            {
                // ... process the retrieved data as needed ...
                runeData = JObject.Parse(jsonSpellData).ToObject<RuneData.RuneDataRoot>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            return runeData;
        }

        public async Task<dynamic> GetSummonerMatchesFromApiAsync(string summonerPUUID)
        {
            MatchIDUsingpuuid playerMatchIDs = new MatchIDUsingpuuid();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonDataString = await riotAPIService.GetSummonerMatchHistoryListByPuuid(summonerPUUID);

            try
            {
                // ... process the retrieved data as needed ...
                playerMatchIDs = JObject.Parse(jsonDataString).ToObject<MatchIDUsingpuuid>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            // Return the processed data
            return playerMatchIDs;
        }

        public async Task<dynamic> GetSummonerMatchDataFromApiAsync(string matchID)
        {
            MatchGameData playerMatchIDs = new MatchGameData();
            // Create an instance of the API service
            var riotAPIService = new RiotAPIService();

            // Call the API service method to retrieve data
            dynamic jsonDataString = await riotAPIService.GetSummonerMatchDataByMatchID(matchID);

            try
            {
                // ... process the retrieved data as needed ...
                playerMatchIDs = JObject.Parse(jsonDataString).ToObject<MatchIDUsingpuuid>();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }

            // Return the processed data
            return playerMatchIDs;
        }
    }
}
