namespace TaskManagerDAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using TaskManagerDAL.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagerDAL.Context.QuoteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManagerDAL.Context.QuoteContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var quotes = new List<Quote>
            {
                new Quote{QuoteType="GP-233",Contact="Sharyl",DueDate=DateTime.Parse("2017-12-20T01:35:19Z"),TaskDescription="In hac habitasse platea dictumst.",TaskType="velit eu est congue elementum in hac"},
new Quote{QuoteType="WT-452",Contact="Ardith",DueDate=DateTime.Parse("2017-10-19T14:48:55Z"),TaskDescription="Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.",TaskType="sed sagittis nam congue risus semper porta volutpat"},
new Quote{QuoteType="CP-356",Contact="Deena",DueDate=DateTime.Parse("2016-10-23T01:23:46Z"),TaskDescription="Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",TaskType="eget rutrum at lorem integer"},
new Quote{QuoteType="XU-892",Contact="Orbadiah",DueDate=DateTime.Parse("2017-01-21T01:56:45Z"),TaskDescription="Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.",TaskType="primis in"},
new Quote{QuoteType="UG-630",Contact="Gram",DueDate=DateTime.Parse("2017-01-01T07:37:10Z"),TaskDescription="Maecenas ut massa quis augue luctus tincidunt.",TaskType="etiam justo etiam pretium iaculis justo"},
new Quote{QuoteType="DP-799",Contact="Lyell",DueDate=DateTime.Parse("2017-03-29T07:22:38Z"),TaskDescription="Nulla nisl.",TaskType="quis turpis sed ante vivamus tortor"},
new Quote{QuoteType="MB-575",Contact="Elysia",DueDate=DateTime.Parse("2017-08-20T06:36:45Z"),TaskDescription="Etiam vel augue.",TaskType="gravida sem praesent id massa id nisl venenatis"},
new Quote{QuoteType="EK-776",Contact="Adams",DueDate=DateTime.Parse("2020-06-11T22:19:36Z"),TaskDescription="Vivamus tortor. Duis mattis egestas metus.",TaskType="at lorem integer"},
new Quote{QuoteType="LO-354",Contact="Justis",DueDate=DateTime.Parse("2020-01-16T05:12:00Z"),TaskDescription="Nulla justo.",TaskType="pellentesque at nulla suspendisse potenti cras in"},
new Quote{QuoteType="FJ-819",Contact="Haleigh",DueDate=DateTime.Parse("2017-12-12T15:34:59Z"),TaskDescription="In hac habitasse platea dictumst.",TaskType="penatibus et magnis dis parturient montes nascetur"},
new Quote{QuoteType="IT-408",Contact="Myrta",DueDate=DateTime.Parse("2020-03-22T06:42:05Z"),TaskDescription="Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.",TaskType="ac consequat"},
new Quote{QuoteType="DQ-573",Contact="Henry",DueDate=DateTime.Parse("2019-11-13T02:41:01Z"),TaskDescription="Aliquam sit amet diam in magna bibendum imperdiet.",TaskType="est phasellus sit"},
new Quote{QuoteType="MQ-813",Contact="Henryetta",DueDate=DateTime.Parse("2018-12-30T08:22:58Z"),TaskDescription="Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.",TaskType="felis eu sapien cursus"},
new Quote{QuoteType="EU-936",Contact="Sarina",DueDate=DateTime.Parse("2017-08-23T00:37:13Z"),TaskDescription="Suspendisse potenti.",TaskType="primis in faucibus orci"},
new Quote{QuoteType="VW-252",Contact="Gennifer",DueDate=DateTime.Parse("2019-04-19T00:53:39Z"),TaskDescription="Praesent blandit. Nam nulla.",TaskType="justo sit"},
new Quote{QuoteType="DS-610",Contact="Grayce",DueDate=DateTime.Parse("2019-06-04T07:16:19Z"),TaskDescription="Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.",TaskType="curabitur in libero ut"},
new Quote{QuoteType="MN-302",Contact="Eduino",DueDate=DateTime.Parse("2016-09-13T02:51:53Z"),TaskDescription="Integer non velit.",TaskType="convallis duis consequat dui nec nisi volutpat eleifend"},
new Quote{QuoteType="WA-609",Contact="Emelen",DueDate=DateTime.Parse("2019-03-28T19:13:56Z"),TaskDescription="Morbi ut odio. Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.",TaskType="mattis pulvinar nulla pede ullamcorper augue"},
new Quote{QuoteType="SY-597",Contact="Jodi",DueDate=DateTime.Parse("2017-08-24T01:11:12Z"),TaskDescription="Vivamus vestibulum sagittis sapien.",TaskType="metus arcu adipiscing molestie hendrerit at vulputate"},
new Quote{QuoteType="HW-509",Contact="Tades",DueDate=DateTime.Parse("2017-12-24T23:10:46Z"),TaskDescription="Ut tellus.",TaskType="ac leo pellentesque ultrices mattis odio"},
new Quote{QuoteType="RX-635",Contact="Che",DueDate=DateTime.Parse("2016-12-01T04:23:40Z"),TaskDescription="Vestibulum ac est lacinia nisi venenatis tristique.",TaskType="eleifend donec ut dolor morbi vel lectus"},
new Quote{QuoteType="FB-160",Contact="Donn",DueDate=DateTime.Parse("2017-02-23T14:06:22Z"),TaskDescription="Sed ante.",TaskType="sapien in sapien iaculis congue vivamus metus arcu"},
new Quote{QuoteType="BX-359",Contact="Tamas",DueDate=DateTime.Parse("2019-10-16T06:23:27Z"),TaskDescription="Phasellus in felis. Donec semper sapien a libero.",TaskType="id ligula"},
new Quote{QuoteType="VU-746",Contact="Kellina",DueDate=DateTime.Parse("2019-04-14T20:35:25Z"),TaskDescription="Quisque ut erat.",TaskType="convallis nulla neque"},
new Quote{QuoteType="BH-813",Contact="Lion",DueDate=DateTime.Parse("2018-09-14T01:52:58Z"),TaskDescription="Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.",TaskType="tristique fusce congue diam id"},
new Quote{QuoteType="KU-010",Contact="Reuven",DueDate=DateTime.Parse("2020-06-14T13:55:11Z"),TaskDescription="Integer a nibh. In quis justo.",TaskType="cursus vestibulum proin eu mi"},
new Quote{QuoteType="VY-905",Contact="Charles",DueDate=DateTime.Parse("2018-04-23T16:38:02Z"),TaskDescription="Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.",TaskType="praesent blandit lacinia erat vestibulum sed"},
new Quote{QuoteType="SM-642",Contact="Desdemona",DueDate=DateTime.Parse("2017-06-20T15:31:28Z"),TaskDescription="Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.",TaskType="in quis justo maecenas rhoncus"},
new Quote{QuoteType="SQ-443",Contact="Onfroi",DueDate=DateTime.Parse("2020-02-28T16:13:48Z"),TaskDescription="Proin at turpis a pede posuere nonummy.",TaskType="ut nulla sed accumsan felis ut"},
new Quote{QuoteType="FZ-558",Contact="Jenni",DueDate=DateTime.Parse("2017-07-05T16:05:58Z"),TaskDescription="Suspendisse ornare consequat lectus.",TaskType="felis sed interdum venenatis turpis enim blandit mi"},
new Quote{QuoteType="BP-867",Contact="Hewett",DueDate=DateTime.Parse("2019-06-04T15:05:48Z"),TaskDescription="Phasellus sit amet erat. Nulla tempus.",TaskType="morbi vel lectus"},
new Quote{QuoteType="UG-937",Contact="Fergus",DueDate=DateTime.Parse("2019-09-24T03:23:42Z"),TaskDescription="Aliquam erat volutpat. In congue.",TaskType="natoque penatibus et"},
new Quote{QuoteType="UC-524",Contact="Winston",DueDate=DateTime.Parse("2017-06-25T18:43:46Z"),TaskDescription="Suspendisse potenti.",TaskType="dolor sit amet consectetuer adipiscing elit"},
new Quote{QuoteType="JT-244",Contact="Douglass",DueDate=DateTime.Parse("2018-03-27T12:27:59Z"),TaskDescription="In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",TaskType="amet sem"},
new Quote{QuoteType="UO-561",Contact="Andriana",DueDate=DateTime.Parse("2019-09-24T06:17:26Z"),TaskDescription="Sed accumsan felis.",TaskType="eleifend pede libero quis orci nullam molestie"},
new Quote{QuoteType="MD-151",Contact="Teresa",DueDate=DateTime.Parse("2018-02-12T09:43:17Z"),TaskDescription="Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.",TaskType="amet lobortis"},
new Quote{QuoteType="UM-826",Contact="Cooper",DueDate=DateTime.Parse("2017-01-16T22:39:12Z"),TaskDescription="Aenean lectus.",TaskType="fusce posuere felis sed lacus"},
new Quote{QuoteType="PC-886",Contact="Gerta",DueDate=DateTime.Parse("2017-09-20T16:15:18Z"),TaskDescription="Pellentesque at nulla.",TaskType="in eleifend quam a odio in hac habitasse"},
new Quote{QuoteType="YD-653",Contact="Grantley",DueDate=DateTime.Parse("2018-06-11T07:45:09Z"),TaskDescription="Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.",TaskType="massa tempor"},
new Quote{QuoteType="YG-290",Contact="Zachariah",DueDate=DateTime.Parse("2019-06-29T13:11:48Z"),TaskDescription="Mauris sit amet eros.",TaskType="erat volutpat in congue etiam justo"},
new Quote{QuoteType="VU-239",Contact="Glad",DueDate=DateTime.Parse("2020-06-05T08:44:40Z"),TaskDescription="Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend.",TaskType="rutrum rutrum"},
new Quote{QuoteType="MS-087",Contact="Elnore",DueDate=DateTime.Parse("2019-11-18T03:45:27Z"),TaskDescription="Vestibulum sed magna at nunc commodo placerat. Praesent blandit.",TaskType="amet nunc viverra dapibus"},
new Quote{QuoteType="ZE-966",Contact="Amalita",DueDate=DateTime.Parse("2018-06-23T13:59:22Z"),TaskDescription="Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.",TaskType="augue quam sollicitudin vitae"},
new Quote{QuoteType="LA-603",Contact="Casandra",DueDate=DateTime.Parse("2017-10-29T15:20:13Z"),TaskDescription="Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.",TaskType="sem fusce consequat nulla nisl nunc nisl"},
new Quote{QuoteType="KN-683",Contact="Nathanial",DueDate=DateTime.Parse("2020-02-01T01:43:28Z"),TaskDescription="Sed accumsan felis.",TaskType="in imperdiet et commodo vulputate justo in blandit"},
new Quote{QuoteType="OY-718",Contact="Byrle",DueDate=DateTime.Parse("2018-05-29T18:49:39Z"),TaskDescription="Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",TaskType="est risus auctor"},
new Quote{QuoteType="OL-695",Contact="Dorisa",DueDate=DateTime.Parse("2017-11-19T22:53:31Z"),TaskDescription="Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.",TaskType="feugiat et eros"},
new Quote{QuoteType="IT-545",Contact="Constanta",DueDate=DateTime.Parse("2017-06-18T18:31:25Z"),TaskDescription="Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum.",TaskType="nascetur ridiculus"},
new Quote{QuoteType="ZO-507",Contact="Silvain",DueDate=DateTime.Parse("2016-11-20T02:34:40Z"),TaskDescription="In sagittis dui vel nisl. Duis ac nibh.",TaskType="parturient montes nascetur ridiculus mus etiam vel"},
new Quote{QuoteType="HR-818",Contact="Fernande",DueDate=DateTime.Parse("2019-07-27T12:21:24Z"),TaskDescription="Aenean auctor gravida sem.",TaskType="erat id mauris vulputate"},
new Quote{QuoteType="YW-794",Contact="Niko",DueDate=DateTime.Parse("2017-01-20T00:55:48Z"),TaskDescription="Aliquam sit amet diam in magna bibendum imperdiet.",TaskType="vestibulum aliquet ultrices erat tortor sollicitudin mi sit"},
new Quote{QuoteType="XH-263",Contact="Gustaf",DueDate=DateTime.Parse("2017-01-30T21:48:55Z"),TaskDescription="Praesent lectus.",TaskType="metus aenean fermentum"},
new Quote{QuoteType="ED-239",Contact="Isaiah",DueDate=DateTime.Parse("2017-04-06T15:22:35Z"),TaskDescription="Phasellus id sapien in sapien iaculis congue.",TaskType="et ultrices posuere cubilia"},
new Quote{QuoteType="ET-601",Contact="Estella",DueDate=DateTime.Parse("2019-02-26T14:56:59Z"),TaskDescription="Proin eu mi. Nulla ac enim.",TaskType="orci vehicula"},
new Quote{QuoteType="CR-907",Contact="Nike",DueDate=DateTime.Parse("2018-05-18T03:58:30Z"),TaskDescription="Donec posuere metus vitae ipsum. Aliquam non mauris.",TaskType="quam a odio in hac"},
new Quote{QuoteType="VS-965",Contact="Rickie",DueDate=DateTime.Parse("2016-07-26T02:15:35Z"),TaskDescription="Donec dapibus.",TaskType="ultrices enim lorem ipsum dolor"},
new Quote{QuoteType="QS-560",Contact="Rosette",DueDate=DateTime.Parse("2018-07-06T04:09:45Z"),TaskDescription="Donec ut dolor.",TaskType="praesent blandit nam"},
new Quote{QuoteType="SD-190",Contact="Shelby",DueDate=DateTime.Parse("2017-03-14T04:07:13Z"),TaskDescription="Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",TaskType="suspendisse potenti"},
new Quote{QuoteType="RM-947",Contact="Reece",DueDate=DateTime.Parse("2019-09-02T12:12:22Z"),TaskDescription="Phasellus sit amet erat.",TaskType="libero nam dui proin leo"},
new Quote{QuoteType="XI-860",Contact="Juli",DueDate=DateTime.Parse("2016-09-21T14:11:54Z"),TaskDescription="Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.",TaskType="libero nam dui proin leo odio porttitor"},
new Quote{QuoteType="PH-076",Contact="Edgar",DueDate=DateTime.Parse("2016-07-27T22:04:48Z"),TaskDescription="Morbi non quam nec dui luctus rutrum.",TaskType="hac habitasse platea dictumst aliquam augue"},
new Quote{QuoteType="ZU-377",Contact="Brigham",DueDate=DateTime.Parse("2019-05-06T05:36:13Z"),TaskDescription="Morbi a ipsum. Integer a nibh.",TaskType="justo sollicitudin ut"},
new Quote{QuoteType="DR-750",Contact="Garvey",DueDate=DateTime.Parse("2019-04-24T18:14:13Z"),TaskDescription="Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.",TaskType="orci luctus et ultrices posuere cubilia"},
new Quote{QuoteType="WS-027",Contact="Colman",DueDate=DateTime.Parse("2019-10-29T09:48:34Z"),TaskDescription="Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit.",TaskType="eget tincidunt eget tempus vel pede"},
new Quote{QuoteType="TN-935",Contact="Dolorita",DueDate=DateTime.Parse("2016-07-26T10:54:51Z"),TaskDescription="In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.",TaskType="morbi non"},
new Quote{QuoteType="PL-134",Contact="Mycah",DueDate=DateTime.Parse("2018-08-11T08:43:35Z"),TaskDescription="Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.",TaskType="luctus tincidunt"},
new Quote{QuoteType="XO-334",Contact="Ros",DueDate=DateTime.Parse("2018-02-12T18:15:05Z"),TaskDescription="Nullam sit amet turpis elementum ligula vehicula consequat.",TaskType="praesent blandit lacinia"},
new Quote{QuoteType="SA-451",Contact="Evered",DueDate=DateTime.Parse("2019-10-28T09:21:27Z"),TaskDescription="Pellentesque at nulla. Suspendisse potenti.",TaskType="nunc nisl duis bibendum felis sed interdum venenatis"},
new Quote{QuoteType="EV-568",Contact="Edgardo",DueDate=DateTime.Parse("2018-01-30T16:11:05Z"),TaskDescription="Phasellus sit amet erat.",TaskType="lacinia sapien"},
new Quote{QuoteType="WM-615",Contact="Martino",DueDate=DateTime.Parse("2019-05-21T02:39:09Z"),TaskDescription="Sed sagittis.",TaskType="amet eleifend pede libero quis orci nullam molestie"},
new Quote{QuoteType="UG-980",Contact="Arnuad",DueDate=DateTime.Parse("2017-10-14T03:52:35Z"),TaskDescription="Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy.",TaskType="enim leo rhoncus sed vestibulum"},
new Quote{QuoteType="EQ-135",Contact="Kora",DueDate=DateTime.Parse("2017-03-27T18:05:07Z"),TaskDescription="Fusce consequat. Nulla nisl.",TaskType="auctor gravida sem praesent id massa"},
new Quote{QuoteType="WM-367",Contact="Bettye",DueDate=DateTime.Parse("2017-11-14T11:33:47Z"),TaskDescription="Donec vitae nisi.",TaskType="ac nulla sed vel enim"},
new Quote{QuoteType="CR-633",Contact="Mehetabel",DueDate=DateTime.Parse("2017-02-24T06:14:35Z"),TaskDescription="Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.",TaskType="orci nullam molestie nibh in lectus pellentesque"},
new Quote{QuoteType="ZQ-132",Contact="Dalis",DueDate=DateTime.Parse("2018-02-26T23:38:53Z"),TaskDescription="Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.",TaskType="mauris ullamcorper purus"},
new Quote{QuoteType="HF-687",Contact="Cathlene",DueDate=DateTime.Parse("2019-11-21T20:06:00Z"),TaskDescription="Mauris ullamcorper purus sit amet nulla.",TaskType="donec ut mauris eget massa tempor convallis"},
new Quote{QuoteType="RD-169",Contact="Yoshi",DueDate=DateTime.Parse("2018-05-14T23:13:57Z"),TaskDescription="Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.",TaskType="montes nascetur ridiculus mus etiam"},
new Quote{QuoteType="UT-317",Contact="Wynny",DueDate=DateTime.Parse("2018-02-23T15:43:00Z"),TaskDescription="Suspendisse ornare consequat lectus.",TaskType="vestibulum ac est lacinia nisi"},
new Quote{QuoteType="KQ-333",Contact="Dallon",DueDate=DateTime.Parse("2018-11-14T16:07:47Z"),TaskDescription="Donec ut dolor.",TaskType="odio porttitor id consequat"},
new Quote{QuoteType="VM-875",Contact="Greggory",DueDate=DateTime.Parse("2019-06-05T19:54:02Z"),TaskDescription="Integer tincidunt ante vel ipsum.",TaskType="non mauris morbi non lectus aliquam sit"},
new Quote{QuoteType="SG-331",Contact="Goran",DueDate=DateTime.Parse("2018-12-10T13:34:28Z"),TaskDescription="Praesent blandit. Nam nulla.",TaskType="sed magna"},
new Quote{QuoteType="FM-846",Contact="Delinda",DueDate=DateTime.Parse("2017-01-23T23:45:03Z"),TaskDescription="Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.",TaskType="aliquam quis turpis"},
new Quote{QuoteType="IW-887",Contact="Junina",DueDate=DateTime.Parse("2017-06-27T21:58:10Z"),TaskDescription="Proin interdum mauris non ligula pellentesque ultrices.",TaskType="duis mattis egestas metus"},
new Quote{QuoteType="ZY-550",Contact="Roxanne",DueDate=DateTime.Parse("2020-02-02T18:02:30Z"),TaskDescription="Praesent lectus.",TaskType="vulputate vitae nisl aenean lectus pellentesque"},
new Quote{QuoteType="BS-416",Contact="Freemon",DueDate=DateTime.Parse("2019-07-31T19:32:42Z"),TaskDescription="Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.",TaskType="interdum mauris non ligula pellentesque ultrices phasellus"},
new Quote{QuoteType="JZ-175",Contact="Noell",DueDate=DateTime.Parse("2017-05-15T16:19:58Z"),TaskDescription="Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim.",TaskType="molestie lorem quisque ut erat curabitur gravida nisi"},
new Quote{QuoteType="UT-373",Contact="Shea",DueDate=DateTime.Parse("2019-04-15T14:04:18Z"),TaskDescription="Nulla facilisi. Cras non velit nec nisi vulputate nonummy.",TaskType="pellentesque volutpat dui maecenas tristique est et"},
new Quote{QuoteType="FS-334",Contact="Moria",DueDate=DateTime.Parse("2019-06-16T12:27:25Z"),TaskDescription="Morbi a ipsum. Integer a nibh.",TaskType="magna at nunc commodo placerat praesent blandit"},
new Quote{QuoteType="XN-923",Contact="Beatrix",DueDate=DateTime.Parse("2019-04-05T02:42:28Z"),TaskDescription="In eleifend quam a odio. In hac habitasse platea dictumst.",TaskType="vestibulum ante ipsum primis in faucibus"},
new Quote{QuoteType="YL-250",Contact="Hatty",DueDate=DateTime.Parse("2018-05-12T04:19:03Z"),TaskDescription="Nam dui.",TaskType="eleifend luctus ultricies eu nibh quisque id justo"},
new Quote{QuoteType="KG-191",Contact="Margarete",DueDate=DateTime.Parse("2018-12-20T21:25:09Z"),TaskDescription="Donec vitae nisi.",TaskType="sit amet sapien dignissim vestibulum"},
new Quote{QuoteType="CT-502",Contact="Jaymee",DueDate=DateTime.Parse("2019-11-21T21:42:26Z"),TaskDescription="Nullam varius. Nulla facilisi.",TaskType="elementum nullam varius nulla facilisi"},
new Quote{QuoteType="ZM-923",Contact="Drusilla",DueDate=DateTime.Parse("2020-03-03T23:18:18Z"),TaskDescription="Donec quis orci eget orci vehicula condimentum.",TaskType="duis aliquam convallis nunc proin at turpis a"},
new Quote{QuoteType="AM-280",Contact="Bunny",DueDate=DateTime.Parse("2019-06-08T01:49:23Z"),TaskDescription="Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus.",TaskType="eleifend donec ut dolor"},
new Quote{QuoteType="JP-204",Contact="Willem",DueDate=DateTime.Parse("2019-12-24T10:25:02Z"),TaskDescription="Vestibulum rutrum rutrum neque.",TaskType="nulla tempus vivamus in felis eu sapien cursus"},
new Quote{QuoteType="ZL-697",Contact="Leopold",DueDate=DateTime.Parse("2018-07-19T18:00:50Z"),TaskDescription="Mauris sit amet eros.",TaskType="vulputate nonummy maecenas tincidunt lacus at velit"},
new Quote{QuoteType="BY-588",Contact="Shellie",DueDate=DateTime.Parse("2018-07-10T09:24:35Z"),TaskDescription="Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.",TaskType="sagittis dui vel nisl"},
new Quote{QuoteType="IR-364",Contact="Jean",DueDate=DateTime.Parse("2018-12-16T04:13:41Z"),TaskDescription="Curabitur convallis.",TaskType="nulla ultrices aliquet"},
new Quote{QuoteType="SJ-999",Contact="Maximilien",DueDate=DateTime.Parse("2018-04-14T07:39:46Z"),TaskDescription="Integer non velit.",TaskType="donec posuere metus vitae ipsum aliquam"},
new Quote{QuoteType="OZ-833",Contact="Trueman",DueDate=DateTime.Parse("2016-07-24T03:07:30Z"),TaskDescription="Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.",TaskType="convallis nunc proin at turpis a pede posuere"}
            };

            quotes.ForEach(s => context.Quotes.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();
        }
    }
}
