// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable InvalidXmlDocComment
namespace osu.Framework.Graphics.Sprites
{
    public static class FontAwesome
    {
        public static IconUsage Get(int icon) => new IconUsage((char)icon, "FontAwesome");

        public static class Brands
        {
            public static IconUsage Get(int icon) => FontAwesome.Get(icon).With(weight: "Brands");

            /// <summary>
            /// 500px
            /// </summary>
            public static IconUsage Icon500Px => Get(0xf26e);

            /// <summary>
            /// Accessible Icon
            /// </summary>
            public static IconUsage AccessibleIcon => Get(0xf368);

            /// <summary>
            /// Accusoft
            /// </summary>
            public static IconUsage Accusoft => Get(0xf369);

            /// <summary>
            /// Acquisitions Incorporated
            /// </summary>
            public static IconUsage AcquisitionsIncorporated => Get(0xf6af);

            /// <summary>
            /// App.net
            /// </summary>
            public static IconUsage Adn => Get(0xf170);

            /// <summary>
            /// Adobe
            /// </summary>
            public static IconUsage Adobe => Get(0xf778);

            /// <summary>
            /// Adversal
            /// </summary>
            public static IconUsage Adversal => Get(0xf36a);

            /// <summary>
            /// affiliatetheme
            /// </summary>
            public static IconUsage Affiliatetheme => Get(0xf36b);

            /// <summary>
            /// Airbnb
            /// </summary>
            public static IconUsage Airbnb => Get(0xf834);

            /// <summary>
            /// Algolia
            /// </summary>
            public static IconUsage Algolia => Get(0xf36c);

            /// <summary>
            /// Alipay
            /// </summary>
            public static IconUsage Alipay => Get(0xf642);

            /// <summary>
            /// Amazon
            /// </summary>
            public static IconUsage Amazon => Get(0xf270);

            /// <summary>
            /// Amazon Pay
            /// </summary>
            public static IconUsage AmazonPay => Get(0xf42c);

            /// <summary>
            /// Amilia
            /// </summary>
            public static IconUsage Amilia => Get(0xf36d);

            /// <summary>
            /// Android
            /// </summary>
            public static IconUsage Android => Get(0xf17b);

            /// <summary>
            /// AngelList
            /// </summary>
            public static IconUsage Angellist => Get(0xf209);

            /// <summary>
            /// Angry Creative
            /// </summary>
            public static IconUsage Angrycreative => Get(0xf36e);

            /// <summary>
            /// Angular
            /// </summary>
            public static IconUsage Angular => Get(0xf420);

            /// <summary>
            /// App Store
            /// </summary>
            public static IconUsage AppStore => Get(0xf36f);

            /// <summary>
            /// iOS App Store
            /// </summary>
            public static IconUsage AppStoreIos => Get(0xf370);

            /// <summary>
            /// Apper Systems AB
            /// </summary>
            public static IconUsage Apper => Get(0xf371);

            /// <summary>
            /// Apple
            /// </summary>
            public static IconUsage Apple => Get(0xf179);

            /// <summary>
            /// Apple Pay
            /// </summary>
            public static IconUsage ApplePay => Get(0xf415);

            /// <summary>
            /// Artstation
            /// </summary>
            public static IconUsage Artstation => Get(0xf77a);

            /// <summary>
            /// Asymmetrik, Ltd.
            /// </summary>
            public static IconUsage Asymmetrik => Get(0xf372);

            /// <summary>
            /// Atlassian
            /// </summary>
            public static IconUsage Atlassian => Get(0xf77b);

            /// <summary>
            /// Audible
            /// </summary>
            public static IconUsage Audible => Get(0xf373);

            /// <summary>
            /// Autoprefixer
            /// </summary>
            public static IconUsage Autoprefixer => Get(0xf41c);

            /// <summary>
            /// avianex
            /// </summary>
            public static IconUsage Avianex => Get(0xf374);

            /// <summary>
            /// Aviato
            /// </summary>
            public static IconUsage Aviato => Get(0xf421);

            /// <summary>
            /// Amazon Web Services (AWS)
            /// </summary>
            public static IconUsage Aws => Get(0xf375);

            /// <summary>
            /// Bandcamp
            /// </summary>
            public static IconUsage Bandcamp => Get(0xf2d5);

            /// <summary>
            /// Battle.net
            /// </summary>
            public static IconUsage BattleNet => Get(0xf835);

            /// <summary>
            /// Behance
            /// </summary>
            public static IconUsage Behance => Get(0xf1b4);

            /// <summary>
            /// Behance Square
            /// </summary>
            public static IconUsage BehanceSquare => Get(0xf1b5);

            /// <summary>
            /// BIMobject
            /// </summary>
            public static IconUsage Bimobject => Get(0xf378);

            /// <summary>
            /// Bitbucket
            /// </summary>
            public static IconUsage Bitbucket => Get(0xf171);

            /// <summary>
            /// Bitcoin
            /// </summary>
            public static IconUsage Bitcoin => Get(0xf379);

            /// <summary>
            /// Bity
            /// </summary>
            public static IconUsage Bity => Get(0xf37a);

            /// <summary>
            /// Font Awesome Black Tie
            /// </summary>
            public static IconUsage BlackTie => Get(0xf27e);

            /// <summary>
            /// BlackBerry
            /// </summary>
            public static IconUsage Blackberry => Get(0xf37b);

            /// <summary>
            /// Blogger
            /// </summary>
            public static IconUsage Blogger => Get(0xf37c);

            /// <summary>
            /// Blogger B
            /// </summary>
            public static IconUsage BloggerB => Get(0xf37d);

            /// <summary>
            /// Bluetooth
            /// </summary>
            public static IconUsage Bluetooth => Get(0xf293);

            /// <summary>
            /// Bluetooth
            /// </summary>
            public static IconUsage BluetoothB => Get(0xf294);

            /// <summary>
            /// Bootstrap
            /// </summary>
            public static IconUsage Bootstrap => Get(0xf836);

            /// <summary>
            /// BTC
            /// </summary>
            public static IconUsage Btc => Get(0xf15a);

            /// <summary>
            /// Buffer
            /// </summary>
            public static IconUsage Buffer => Get(0xf837);

            /// <summary>
            /// BÃ¼romÃ¶bel-Experte GmbH & Co. KG.
            /// </summary>
            public static IconUsage Buromobelexperte => Get(0xf37f);

            /// <summary>
            /// BuySellAds
            /// </summary>
            public static IconUsage Buysellads => Get(0xf20d);

            /// <summary>
            /// Canadian Maple Leaf
            /// </summary>
            public static IconUsage CanadianMapleLeaf => Get(0xf785);

            /// <summary>
            /// Amazon Pay Credit Card
            /// </summary>
            public static IconUsage CcAmazonPay => Get(0xf42d);

            /// <summary>
            /// American Express Credit Card
            /// </summary>
            public static IconUsage CcAmex => Get(0xf1f3);

            /// <summary>
            /// Apple Pay Credit Card
            /// </summary>
            public static IconUsage CcApplePay => Get(0xf416);

            /// <summary>
            /// Diner's Club Credit Card
            /// </summary>
            public static IconUsage CcDinersClub => Get(0xf24c);

            /// <summary>
            /// Discover Credit Card
            /// </summary>
            public static IconUsage CcDiscover => Get(0xf1f2);

            /// <summary>
            /// JCB Credit Card
            /// </summary>
            public static IconUsage CcJcb => Get(0xf24b);

            /// <summary>
            /// MasterCard Credit Card
            /// </summary>
            public static IconUsage CcMastercard => Get(0xf1f1);

            /// <summary>
            /// Paypal Credit Card
            /// </summary>
            public static IconUsage CcPaypal => Get(0xf1f4);

            /// <summary>
            /// Stripe Credit Card
            /// </summary>
            public static IconUsage CcStripe => Get(0xf1f5);

            /// <summary>
            /// Visa Credit Card
            /// </summary>
            public static IconUsage CcVisa => Get(0xf1f0);

            /// <summary>
            /// Centercode
            /// </summary>
            public static IconUsage Centercode => Get(0xf380);

            /// <summary>
            /// Centos
            /// </summary>
            public static IconUsage Centos => Get(0xf789);

            /// <summary>
            /// Chrome
            /// </summary>
            public static IconUsage Chrome => Get(0xf268);

            /// <summary>
            /// Chromecast
            /// </summary>
            public static IconUsage Chromecast => Get(0xf838);

            /// <summary>
            /// cloudscale.ch
            /// </summary>
            public static IconUsage Cloudscale => Get(0xf383);

            /// <summary>
            /// Cloudsmith
            /// </summary>
            public static IconUsage Cloudsmith => Get(0xf384);

            /// <summary>
            /// cloudversify
            /// </summary>
            public static IconUsage Cloudversify => Get(0xf385);

            /// <summary>
            /// Codepen
            /// </summary>
            public static IconUsage Codepen => Get(0xf1cb);

            /// <summary>
            /// Codie Pie
            /// </summary>
            public static IconUsage Codiepie => Get(0xf284);

            /// <summary>
            /// Confluence
            /// </summary>
            public static IconUsage Confluence => Get(0xf78d);

            /// <summary>
            /// Connect Develop
            /// </summary>
            public static IconUsage Connectdevelop => Get(0xf20e);

            /// <summary>
            /// Contao
            /// </summary>
            public static IconUsage Contao => Get(0xf26d);

            /// <summary>
            /// cPanel
            /// </summary>
            public static IconUsage Cpanel => Get(0xf388);

            /// <summary>
            /// Creative Commons
            /// </summary>
            public static IconUsage CreativeCommons => Get(0xf25e);

            /// <summary>
            /// Creative Commons Attribution
            /// </summary>
            public static IconUsage CreativeCommonsBy => Get(0xf4e7);

            /// <summary>
            /// Creative Commons Noncommercial
            /// </summary>
            public static IconUsage CreativeCommonsNc => Get(0xf4e8);

            /// <summary>
            /// Creative Commons Noncommercial (Euro Sign)
            /// </summary>
            public static IconUsage CreativeCommonsNcEu => Get(0xf4e9);

            /// <summary>
            /// Creative Commons Noncommercial (Yen Sign)
            /// </summary>
            public static IconUsage CreativeCommonsNcJp => Get(0xf4ea);

            /// <summary>
            /// Creative Commons No Derivative Works
            /// </summary>
            public static IconUsage CreativeCommonsNd => Get(0xf4eb);

            /// <summary>
            /// Creative Commons Public Domain
            /// </summary>
            public static IconUsage CreativeCommonsPd => Get(0xf4ec);

            /// <summary>
            /// Alternate Creative Commons Public Domain
            /// </summary>
            public static IconUsage CreativeCommonsPdAlt => Get(0xf4ed);

            /// <summary>
            /// Creative Commons Remix
            /// </summary>
            public static IconUsage CreativeCommonsRemix => Get(0xf4ee);

            /// <summary>
            /// Creative Commons Share Alike
            /// </summary>
            public static IconUsage CreativeCommonsSa => Get(0xf4ef);

            /// <summary>
            /// Creative Commons Sampling
            /// </summary>
            public static IconUsage CreativeCommonsSampling => Get(0xf4f0);

            /// <summary>
            /// Creative Commons Sampling +
            /// </summary>
            public static IconUsage CreativeCommonsSamplingPlus => Get(0xf4f1);

            /// <summary>
            /// Creative Commons Share
            /// </summary>
            public static IconUsage CreativeCommonsShare => Get(0xf4f2);

            /// <summary>
            /// Creative Commons CC0
            /// </summary>
            public static IconUsage CreativeCommonsZero => Get(0xf4f3);

            /// <summary>
            /// Critical Role
            /// </summary>
            public static IconUsage CriticalRole => Get(0xf6c9);

            /// <summary>
            /// CSS 3 Logo
            /// </summary>
            public static IconUsage Css3 => Get(0xf13c);

            /// <summary>
            /// Alternate CSS3 Logo
            /// </summary>
            public static IconUsage Css3Alt => Get(0xf38b);

            /// <summary>
            /// Cuttlefish
            /// </summary>
            public static IconUsage Cuttlefish => Get(0xf38c);

            /// <summary>
            /// Dungeons & Dragons
            /// </summary>
            public static IconUsage DAndD => Get(0xf38d);

            /// <summary>
            /// D&D Beyond
            /// </summary>
            public static IconUsage DAndDBeyond => Get(0xf6ca);

            /// <summary>
            /// DashCube
            /// </summary>
            public static IconUsage Dashcube => Get(0xf210);

            /// <summary>
            /// Delicious
            /// </summary>
            public static IconUsage Delicious => Get(0xf1a5);

            /// <summary>
            /// deploy.dog
            /// </summary>
            public static IconUsage Deploydog => Get(0xf38e);

            /// <summary>
            /// Deskpro
            /// </summary>
            public static IconUsage Deskpro => Get(0xf38f);

            /// <summary>
            /// DEV
            /// </summary>
            public static IconUsage Dev => Get(0xf6cc);

            /// <summary>
            /// deviantART
            /// </summary>
            public static IconUsage Deviantart => Get(0xf1bd);

            /// <summary>
            /// DHL
            /// </summary>
            public static IconUsage Dhl => Get(0xf790);

            /// <summary>
            /// Diaspora
            /// </summary>
            public static IconUsage Diaspora => Get(0xf791);

            /// <summary>
            /// Digg Logo
            /// </summary>
            public static IconUsage Digg => Get(0xf1a6);

            /// <summary>
            /// Digital Ocean
            /// </summary>
            public static IconUsage DigitalOcean => Get(0xf391);

            /// <summary>
            /// Discord
            /// </summary>
            public static IconUsage Discord => Get(0xf392);

            /// <summary>
            /// Discourse
            /// </summary>
            public static IconUsage Discourse => Get(0xf393);

            /// <summary>
            /// DocHub
            /// </summary>
            public static IconUsage Dochub => Get(0xf394);

            /// <summary>
            /// Docker
            /// </summary>
            public static IconUsage Docker => Get(0xf395);

            /// <summary>
            /// Draft2digital
            /// </summary>
            public static IconUsage Draft2digital => Get(0xf396);

            /// <summary>
            /// Dribbble
            /// </summary>
            public static IconUsage Dribbble => Get(0xf17d);

            /// <summary>
            /// Dribbble Square
            /// </summary>
            public static IconUsage DribbbleSquare => Get(0xf397);

            /// <summary>
            /// Dropbox
            /// </summary>
            public static IconUsage Dropbox => Get(0xf16b);

            /// <summary>
            /// Drupal Logo
            /// </summary>
            public static IconUsage Drupal => Get(0xf1a9);

            /// <summary>
            /// Dyalog
            /// </summary>
            public static IconUsage Dyalog => Get(0xf399);

            /// <summary>
            /// Earlybirds
            /// </summary>
            public static IconUsage Earlybirds => Get(0xf39a);

            /// <summary>
            /// eBay
            /// </summary>
            public static IconUsage Ebay => Get(0xf4f4);

            /// <summary>
            /// Edge Browser
            /// </summary>
            public static IconUsage Edge => Get(0xf282);

            /// <summary>
            /// Elementor
            /// </summary>
            public static IconUsage Elementor => Get(0xf430);

            /// <summary>
            /// Ello
            /// </summary>
            public static IconUsage Ello => Get(0xf5f1);

            /// <summary>
            /// Ember
            /// </summary>
            public static IconUsage Ember => Get(0xf423);

            /// <summary>
            /// Galactic Empire
            /// </summary>
            public static IconUsage Empire => Get(0xf1d1);

            /// <summary>
            /// Envira Gallery
            /// </summary>
            public static IconUsage Envira => Get(0xf299);

            /// <summary>
            /// Erlang
            /// </summary>
            public static IconUsage Erlang => Get(0xf39d);

            /// <summary>
            /// Ethereum
            /// </summary>
            public static IconUsage Ethereum => Get(0xf42e);

            /// <summary>
            /// Etsy
            /// </summary>
            public static IconUsage Etsy => Get(0xf2d7);

            /// <summary>
            /// Evernote
            /// </summary>
            public static IconUsage Evernote => Get(0xf839);

            /// <summary>
            /// ExpeditedSSL
            /// </summary>
            public static IconUsage Expeditedssl => Get(0xf23e);

            /// <summary>
            /// Facebook
            /// </summary>
            public static IconUsage Facebook => Get(0xf09a);

            /// <summary>
            /// Facebook F
            /// </summary>
            public static IconUsage FacebookF => Get(0xf39e);

            /// <summary>
            /// Facebook Messenger
            /// </summary>
            public static IconUsage FacebookMessenger => Get(0xf39f);

            /// <summary>
            /// Facebook Square
            /// </summary>
            public static IconUsage FacebookSquare => Get(0xf082);

            /// <summary>
            /// Fantasy Flight-games
            /// </summary>
            public static IconUsage FantasyFlightGames => Get(0xf6dc);

            /// <summary>
            /// FedEx
            /// </summary>
            public static IconUsage Fedex => Get(0xf797);

            /// <summary>
            /// Fedora
            /// </summary>
            public static IconUsage Fedora => Get(0xf798);

            /// <summary>
            /// Figma
            /// </summary>
            public static IconUsage Figma => Get(0xf799);

            /// <summary>
            /// Firefox
            /// </summary>
            public static IconUsage Firefox => Get(0xf269);

            /// <summary>
            /// First Order
            /// </summary>
            public static IconUsage FirstOrder => Get(0xf2b0);

            /// <summary>
            /// Alternate First Order
            /// </summary>
            public static IconUsage FirstOrderAlt => Get(0xf50a);

            /// <summary>
            /// firstdraft
            /// </summary>
            public static IconUsage Firstdraft => Get(0xf3a1);

            /// <summary>
            /// Flickr
            /// </summary>
            public static IconUsage Flickr => Get(0xf16e);

            /// <summary>
            /// Flipboard
            /// </summary>
            public static IconUsage Flipboard => Get(0xf44d);

            /// <summary>
            /// Fly
            /// </summary>
            public static IconUsage Fly => Get(0xf417);

            /// <summary>
            /// Font Awesome
            /// </summary>
            public static IconUsage IconFontAwesome => Get(0xf2b4);

            /// <summary>
            /// Alternate Font Awesome
            /// </summary>
            public static IconUsage FontAwesomeAlt => Get(0xf35c);

            /// <summary>
            /// Font Awesome Flag
            /// </summary>
            public static IconUsage FontAwesomeFlag => Get(0xf425);

            /// <summary>
            /// Font Awesome Full Logo
            /// </summary>
            public static IconUsage FontAwesomeLogoFull => Get(0xf4e6);

            /// <summary>
            /// Fonticons
            /// </summary>
            public static IconUsage Fonticons => Get(0xf280);

            /// <summary>
            /// Fonticons Fi
            /// </summary>
            public static IconUsage FonticonsFi => Get(0xf3a2);

            /// <summary>
            /// Fort Awesome
            /// </summary>
            public static IconUsage FortAwesome => Get(0xf286);

            /// <summary>
            /// Alternate Fort Awesome
            /// </summary>
            public static IconUsage FortAwesomeAlt => Get(0xf3a3);

            /// <summary>
            /// Forumbee
            /// </summary>
            public static IconUsage Forumbee => Get(0xf211);

            /// <summary>
            /// Foursquare
            /// </summary>
            public static IconUsage Foursquare => Get(0xf180);

            /// <summary>
            /// Free Code Camp
            /// </summary>
            public static IconUsage FreeCodeCamp => Get(0xf2c5);

            /// <summary>
            /// FreeBSD
            /// </summary>
            public static IconUsage Freebsd => Get(0xf3a4);

            /// <summary>
            /// Fulcrum
            /// </summary>
            public static IconUsage Fulcrum => Get(0xf50b);

            /// <summary>
            /// Galactic Republic
            /// </summary>
            public static IconUsage GalacticRepublic => Get(0xf50c);

            /// <summary>
            /// Galactic Senate
            /// </summary>
            public static IconUsage GalacticSenate => Get(0xf50d);

            /// <summary>
            /// Get Pocket
            /// </summary>
            public static IconUsage GetPocket => Get(0xf265);

            /// <summary>
            /// GG Currency
            /// </summary>
            public static IconUsage Gg => Get(0xf260);

            /// <summary>
            /// GG Currency Circle
            /// </summary>
            public static IconUsage GgCircle => Get(0xf261);

            /// <summary>
            /// Git
            /// </summary>
            public static IconUsage Git => Get(0xf1d3);

            /// <summary>
            /// Git Square
            /// </summary>
            public static IconUsage GitSquare => Get(0xf1d2);

            /// <summary>
            /// GitHub
            /// </summary>
            public static IconUsage Github => Get(0xf09b);

            /// <summary>
            /// Alternate GitHub
            /// </summary>
            public static IconUsage GithubAlt => Get(0xf113);

            /// <summary>
            /// GitHub Square
            /// </summary>
            public static IconUsage GithubSquare => Get(0xf092);

            /// <summary>
            /// GitKraken
            /// </summary>
            public static IconUsage Gitkraken => Get(0xf3a6);

            /// <summary>
            /// GitLab
            /// </summary>
            public static IconUsage Gitlab => Get(0xf296);

            /// <summary>
            /// Gitter
            /// </summary>
            public static IconUsage Gitter => Get(0xf426);

            /// <summary>
            /// Glide
            /// </summary>
            public static IconUsage Glide => Get(0xf2a5);

            /// <summary>
            /// Glide G
            /// </summary>
            public static IconUsage GlideG => Get(0xf2a6);

            /// <summary>
            /// Gofore
            /// </summary>
            public static IconUsage Gofore => Get(0xf3a7);

            /// <summary>
            /// Goodreads
            /// </summary>
            public static IconUsage Goodreads => Get(0xf3a8);

            /// <summary>
            /// Goodreads G
            /// </summary>
            public static IconUsage GoodreadsG => Get(0xf3a9);

            /// <summary>
            /// Google Logo
            /// </summary>
            public static IconUsage Google => Get(0xf1a0);

            /// <summary>
            /// Google Drive
            /// </summary>
            public static IconUsage GoogleDrive => Get(0xf3aa);

            /// <summary>
            /// Google Play
            /// </summary>
            public static IconUsage GooglePlay => Get(0xf3ab);

            /// <summary>
            /// Google Plus
            /// </summary>
            public static IconUsage GooglePlus => Get(0xf2b3);

            /// <summary>
            /// Google Plus G
            /// </summary>
            public static IconUsage GooglePlusG => Get(0xf0d5);

            /// <summary>
            /// Google Plus Square
            /// </summary>
            public static IconUsage GooglePlusSquare => Get(0xf0d4);

            /// <summary>
            /// Google Wallet
            /// </summary>
            public static IconUsage GoogleWallet => Get(0xf1ee);

            /// <summary>
            /// Gratipay (Gittip)
            /// </summary>
            public static IconUsage Gratipay => Get(0xf184);

            /// <summary>
            /// Grav
            /// </summary>
            public static IconUsage Grav => Get(0xf2d6);

            /// <summary>
            /// Gripfire, Inc.
            /// </summary>
            public static IconUsage Gripfire => Get(0xf3ac);

            /// <summary>
            /// Grunt
            /// </summary>
            public static IconUsage Grunt => Get(0xf3ad);

            /// <summary>
            /// Gulp
            /// </summary>
            public static IconUsage Gulp => Get(0xf3ae);

            /// <summary>
            /// Hacker News
            /// </summary>
            public static IconUsage HackerNews => Get(0xf1d4);

            /// <summary>
            /// Hacker News Square
            /// </summary>
            public static IconUsage HackerNewsSquare => Get(0xf3af);

            /// <summary>
            /// Hackerrank
            /// </summary>
            public static IconUsage Hackerrank => Get(0xf5f7);

            /// <summary>
            /// Hips
            /// </summary>
            public static IconUsage Hips => Get(0xf452);

            /// <summary>
            /// HireAHelper
            /// </summary>
            public static IconUsage HireAHelper => Get(0xf3b0);

            /// <summary>
            /// Hooli
            /// </summary>
            public static IconUsage Hooli => Get(0xf427);

            /// <summary>
            /// Hornbill
            /// </summary>
            public static IconUsage Hornbill => Get(0xf592);

            /// <summary>
            /// Hotjar
            /// </summary>
            public static IconUsage Hotjar => Get(0xf3b1);

            /// <summary>
            /// Houzz
            /// </summary>
            public static IconUsage Houzz => Get(0xf27c);

            /// <summary>
            /// HTML 5 Logo
            /// </summary>
            public static IconUsage Html5 => Get(0xf13b);

            /// <summary>
            /// HubSpot
            /// </summary>
            public static IconUsage Hubspot => Get(0xf3b2);

            /// <summary>
            /// IMDB
            /// </summary>
            public static IconUsage Imdb => Get(0xf2d8);

            /// <summary>
            /// Instagram
            /// </summary>
            public static IconUsage Instagram => Get(0xf16d);

            /// <summary>
            /// Intercom
            /// </summary>
            public static IconUsage Intercom => Get(0xf7af);

            /// <summary>
            /// Internet-explorer
            /// </summary>
            public static IconUsage InternetExplorer => Get(0xf26b);

            /// <summary>
            /// InVision
            /// </summary>
            public static IconUsage Invision => Get(0xf7b0);

            /// <summary>
            /// ioxhost
            /// </summary>
            public static IconUsage Ioxhost => Get(0xf208);

            /// <summary>
            /// itch.io
            /// </summary>
            public static IconUsage ItchIo => Get(0xf83a);

            /// <summary>
            /// iTunes
            /// </summary>
            public static IconUsage Itunes => Get(0xf3b4);

            /// <summary>
            /// Itunes Note
            /// </summary>
            public static IconUsage ItunesNote => Get(0xf3b5);

            /// <summary>
            /// Java
            /// </summary>
            public static IconUsage Java => Get(0xf4e4);

            /// <summary>
            /// Jedi Order
            /// </summary>
            public static IconUsage JediOrder => Get(0xf50e);

            /// <summary>
            /// Jenkis
            /// </summary>
            public static IconUsage Jenkins => Get(0xf3b6);

            /// <summary>
            /// Jira
            /// </summary>
            public static IconUsage Jira => Get(0xf7b1);

            /// <summary>
            /// Joget
            /// </summary>
            public static IconUsage Joget => Get(0xf3b7);

            /// <summary>
            /// Joomla Logo
            /// </summary>
            public static IconUsage Joomla => Get(0xf1aa);

            /// <summary>
            /// JavaScript (JS)
            /// </summary>
            public static IconUsage Js => Get(0xf3b8);

            /// <summary>
            /// JavaScript (JS) Square
            /// </summary>
            public static IconUsage JsSquare => Get(0xf3b9);

            /// <summary>
            /// jsFiddle
            /// </summary>
            public static IconUsage Jsfiddle => Get(0xf1cc);

            /// <summary>
            /// Kaggle
            /// </summary>
            public static IconUsage Kaggle => Get(0xf5fa);

            /// <summary>
            /// Keybase
            /// </summary>
            public static IconUsage Keybase => Get(0xf4f5);

            /// <summary>
            /// KeyCDN
            /// </summary>
            public static IconUsage Keycdn => Get(0xf3ba);

            /// <summary>
            /// Kickstarter
            /// </summary>
            public static IconUsage Kickstarter => Get(0xf3bb);

            /// <summary>
            /// Kickstarter K
            /// </summary>
            public static IconUsage KickstarterK => Get(0xf3bc);

            /// <summary>
            /// KORVUE
            /// </summary>
            public static IconUsage Korvue => Get(0xf42f);

            /// <summary>
            /// Laravel
            /// </summary>
            public static IconUsage Laravel => Get(0xf3bd);

            /// <summary>
            /// last.fm
            /// </summary>
            public static IconUsage Lastfm => Get(0xf202);

            /// <summary>
            /// last.fm Square
            /// </summary>
            public static IconUsage LastfmSquare => Get(0xf203);

            /// <summary>
            /// Leanpub
            /// </summary>
            public static IconUsage Leanpub => Get(0xf212);

            /// <summary>
            /// Less
            /// </summary>
            public static IconUsage Less => Get(0xf41d);

            /// <summary>
            /// Line
            /// </summary>
            public static IconUsage Line => Get(0xf3c0);

            /// <summary>
            /// LinkedIn
            /// </summary>
            public static IconUsage Linkedin => Get(0xf08c);

            /// <summary>
            /// LinkedIn In
            /// </summary>
            public static IconUsage LinkedinIn => Get(0xf0e1);

            /// <summary>
            /// Linode
            /// </summary>
            public static IconUsage Linode => Get(0xf2b8);

            /// <summary>
            /// Linux
            /// </summary>
            public static IconUsage Linux => Get(0xf17c);

            /// <summary>
            /// lyft
            /// </summary>
            public static IconUsage Lyft => Get(0xf3c3);

            /// <summary>
            /// Magento
            /// </summary>
            public static IconUsage Magento => Get(0xf3c4);

            /// <summary>
            /// Mailchimp
            /// </summary>
            public static IconUsage Mailchimp => Get(0xf59e);

            /// <summary>
            /// Mandalorian
            /// </summary>
            public static IconUsage Mandalorian => Get(0xf50f);

            /// <summary>
            /// Markdown
            /// </summary>
            public static IconUsage Markdown => Get(0xf60f);

            /// <summary>
            /// Mastodon
            /// </summary>
            public static IconUsage Mastodon => Get(0xf4f6);

            /// <summary>
            /// MaxCDN
            /// </summary>
            public static IconUsage Maxcdn => Get(0xf136);

            /// <summary>
            /// MedApps
            /// </summary>
            public static IconUsage Medapps => Get(0xf3c6);

            /// <summary>
            /// Medium
            /// </summary>
            public static IconUsage Medium => Get(0xf23a);

            /// <summary>
            /// Medium M
            /// </summary>
            public static IconUsage MediumM => Get(0xf3c7);

            /// <summary>
            /// MRT
            /// </summary>
            public static IconUsage Medrt => Get(0xf3c8);

            /// <summary>
            /// Meetup
            /// </summary>
            public static IconUsage Meetup => Get(0xf2e0);

            /// <summary>
            /// Megaport
            /// </summary>
            public static IconUsage Megaport => Get(0xf5a3);

            /// <summary>
            /// Mendeley
            /// </summary>
            public static IconUsage Mendeley => Get(0xf7b3);

            /// <summary>
            /// Microsoft
            /// </summary>
            public static IconUsage Microsoft => Get(0xf3ca);

            /// <summary>
            /// Mix
            /// </summary>
            public static IconUsage Mix => Get(0xf3cb);

            /// <summary>
            /// Mixcloud
            /// </summary>
            public static IconUsage Mixcloud => Get(0xf289);

            /// <summary>
            /// Mizuni
            /// </summary>
            public static IconUsage Mizuni => Get(0xf3cc);

            /// <summary>
            /// MODX
            /// </summary>
            public static IconUsage Modx => Get(0xf285);

            /// <summary>
            /// Monero
            /// </summary>
            public static IconUsage Monero => Get(0xf3d0);

            /// <summary>
            /// Napster
            /// </summary>
            public static IconUsage Napster => Get(0xf3d2);

            /// <summary>
            /// Neos
            /// </summary>
            public static IconUsage Neos => Get(0xf612);

            /// <summary>
            /// Nimblr
            /// </summary>
            public static IconUsage Nimblr => Get(0xf5a8);

            /// <summary>
            /// Nintendo Switch
            /// </summary>
            public static IconUsage NintendoSwitch => Get(0xf418);

            /// <summary>
            /// Node.js
            /// </summary>
            public static IconUsage Node => Get(0xf419);

            /// <summary>
            /// Node.js JS
            /// </summary>
            public static IconUsage NodeJs => Get(0xf3d3);

            /// <summary>
            /// npm
            /// </summary>
            public static IconUsage Npm => Get(0xf3d4);

            /// <summary>
            /// NS8
            /// </summary>
            public static IconUsage Ns8 => Get(0xf3d5);

            /// <summary>
            /// Nutritionix
            /// </summary>
            public static IconUsage Nutritionix => Get(0xf3d6);

            /// <summary>
            /// Odnoklassniki
            /// </summary>
            public static IconUsage Odnoklassniki => Get(0xf263);

            /// <summary>
            /// Odnoklassniki Square
            /// </summary>
            public static IconUsage OdnoklassnikiSquare => Get(0xf264);

            /// <summary>
            /// Old Republic
            /// </summary>
            public static IconUsage OldRepublic => Get(0xf510);

            /// <summary>
            /// OpenCart
            /// </summary>
            public static IconUsage Opencart => Get(0xf23d);

            /// <summary>
            /// OpenID
            /// </summary>
            public static IconUsage Openid => Get(0xf19b);

            /// <summary>
            /// Opera
            /// </summary>
            public static IconUsage Opera => Get(0xf26a);

            /// <summary>
            /// Optin Monster
            /// </summary>
            public static IconUsage OptinMonster => Get(0xf23c);

            /// <summary>
            /// Open Source Initiative
            /// </summary>
            public static IconUsage Osi => Get(0xf41a);

            /// <summary>
            /// page4 Corporation
            /// </summary>
            public static IconUsage Page4 => Get(0xf3d7);

            /// <summary>
            /// Pagelines
            /// </summary>
            public static IconUsage Pagelines => Get(0xf18c);

            /// <summary>
            /// Palfed
            /// </summary>
            public static IconUsage Palfed => Get(0xf3d8);

            /// <summary>
            /// Patreon
            /// </summary>
            public static IconUsage Patreon => Get(0xf3d9);

            /// <summary>
            /// Paypal
            /// </summary>
            public static IconUsage Paypal => Get(0xf1ed);

            /// <summary>
            /// Penny Arcade
            /// </summary>
            public static IconUsage PennyArcade => Get(0xf704);

            /// <summary>
            /// Periscope
            /// </summary>
            public static IconUsage Periscope => Get(0xf3da);

            /// <summary>
            /// Phabricator
            /// </summary>
            public static IconUsage Phabricator => Get(0xf3db);

            /// <summary>
            /// Phoenix Framework
            /// </summary>
            public static IconUsage PhoenixFramework => Get(0xf3dc);

            /// <summary>
            /// Phoenix Squadron
            /// </summary>
            public static IconUsage PhoenixSquadron => Get(0xf511);

            /// <summary>
            /// PHP
            /// </summary>
            public static IconUsage Php => Get(0xf457);

            /// <summary>
            /// Pied Piper Logo
            /// </summary>
            public static IconUsage PiedPiper => Get(0xf2ae);

            /// <summary>
            /// Alternate Pied Piper Logo
            /// </summary>
            public static IconUsage PiedPiperAlt => Get(0xf1a8);

            /// <summary>
            /// Pied Piper-hat
            /// </summary>
            public static IconUsage PiedPiperHat => Get(0xf4e5);

            /// <summary>
            /// Pied Piper PP Logo (Old)
            /// </summary>
            public static IconUsage PiedPiperPp => Get(0xf1a7);

            /// <summary>
            /// Pinterest
            /// </summary>
            public static IconUsage Pinterest => Get(0xf0d2);

            /// <summary>
            /// Pinterest P
            /// </summary>
            public static IconUsage PinterestP => Get(0xf231);

            /// <summary>
            /// Pinterest Square
            /// </summary>
            public static IconUsage PinterestSquare => Get(0xf0d3);

            /// <summary>
            /// PlayStation
            /// </summary>
            public static IconUsage Playstation => Get(0xf3df);

            /// <summary>
            /// Product Hunt
            /// </summary>
            public static IconUsage ProductHunt => Get(0xf288);

            /// <summary>
            /// Pushed
            /// </summary>
            public static IconUsage Pushed => Get(0xf3e1);

            /// <summary>
            /// Python
            /// </summary>
            public static IconUsage Python => Get(0xf3e2);

            /// <summary>
            /// QQ
            /// </summary>
            public static IconUsage Qq => Get(0xf1d6);

            /// <summary>
            /// QuinScape
            /// </summary>
            public static IconUsage Quinscape => Get(0xf459);

            /// <summary>
            /// Quora
            /// </summary>
            public static IconUsage Quora => Get(0xf2c4);

            /// <summary>
            /// R Project
            /// </summary>
            public static IconUsage RProject => Get(0xf4f7);

            /// <summary>
            /// Raspberry Pi
            /// </summary>
            public static IconUsage RaspberryPi => Get(0xf7bb);

            /// <summary>
            /// Ravelry
            /// </summary>
            public static IconUsage Ravelry => Get(0xf2d9);

            /// <summary>
            /// React
            /// </summary>
            public static IconUsage React => Get(0xf41b);

            /// <summary>
            /// ReactEurope
            /// </summary>
            public static IconUsage Reacteurope => Get(0xf75d);

            /// <summary>
            /// ReadMe
            /// </summary>
            public static IconUsage Readme => Get(0xf4d5);

            /// <summary>
            /// Rebel Alliance
            /// </summary>
            public static IconUsage Rebel => Get(0xf1d0);

            /// <summary>
            /// red river
            /// </summary>
            public static IconUsage RedRiver => Get(0xf3e3);

            /// <summary>
            /// reddit Logo
            /// </summary>
            public static IconUsage Reddit => Get(0xf1a1);

            /// <summary>
            /// reddit Alien
            /// </summary>
            public static IconUsage RedditAlien => Get(0xf281);

            /// <summary>
            /// reddit Square
            /// </summary>
            public static IconUsage RedditSquare => Get(0xf1a2);

            /// <summary>
            /// Redhat
            /// </summary>
            public static IconUsage Redhat => Get(0xf7bc);

            /// <summary>
            /// Renren
            /// </summary>
            public static IconUsage Renren => Get(0xf18b);

            /// <summary>
            /// replyd
            /// </summary>
            public static IconUsage Replyd => Get(0xf3e6);

            /// <summary>
            /// Researchgate
            /// </summary>
            public static IconUsage Researchgate => Get(0xf4f8);

            /// <summary>
            /// Resolving
            /// </summary>
            public static IconUsage Resolving => Get(0xf3e7);

            /// <summary>
            /// Rev.io
            /// </summary>
            public static IconUsage Rev => Get(0xf5b2);

            /// <summary>
            /// Rocket.Chat
            /// </summary>
            public static IconUsage Rocketchat => Get(0xf3e8);

            /// <summary>
            /// Rockrms
            /// </summary>
            public static IconUsage Rockrms => Get(0xf3e9);

            /// <summary>
            /// Safari
            /// </summary>
            public static IconUsage Safari => Get(0xf267);

            /// <summary>
            /// Salesforce
            /// </summary>
            public static IconUsage Salesforce => Get(0xf83b);

            /// <summary>
            /// Sass
            /// </summary>
            public static IconUsage Sass => Get(0xf41e);

            /// <summary>
            /// SCHLIX
            /// </summary>
            public static IconUsage Schlix => Get(0xf3ea);

            /// <summary>
            /// Scribd
            /// </summary>
            public static IconUsage Scribd => Get(0xf28a);

            /// <summary>
            /// Searchengin
            /// </summary>
            public static IconUsage Searchengin => Get(0xf3eb);

            /// <summary>
            /// Sellcast
            /// </summary>
            public static IconUsage Sellcast => Get(0xf2da);

            /// <summary>
            /// Sellsy
            /// </summary>
            public static IconUsage Sellsy => Get(0xf213);

            /// <summary>
            /// Servicestack
            /// </summary>
            public static IconUsage Servicestack => Get(0xf3ec);

            /// <summary>
            /// Shirts in Bulk
            /// </summary>
            public static IconUsage Shirtsinbulk => Get(0xf214);

            /// <summary>
            /// Shopware
            /// </summary>
            public static IconUsage Shopware => Get(0xf5b5);

            /// <summary>
            /// SimplyBuilt
            /// </summary>
            public static IconUsage Simplybuilt => Get(0xf215);

            /// <summary>
            /// SISTRIX
            /// </summary>
            public static IconUsage Sistrix => Get(0xf3ee);

            /// <summary>
            /// Sith
            /// </summary>
            public static IconUsage Sith => Get(0xf512);

            /// <summary>
            /// Sketch
            /// </summary>
            public static IconUsage Sketch => Get(0xf7c6);

            /// <summary>
            /// skyatlas
            /// </summary>
            public static IconUsage Skyatlas => Get(0xf216);

            /// <summary>
            /// Skype
            /// </summary>
            public static IconUsage Skype => Get(0xf17e);

            /// <summary>
            /// Slack Logo
            /// </summary>
            public static IconUsage Slack => Get(0xf198);

            /// <summary>
            /// Slack Hashtag
            /// </summary>
            public static IconUsage SlackHash => Get(0xf3ef);

            /// <summary>
            /// Slideshare
            /// </summary>
            public static IconUsage Slideshare => Get(0xf1e7);

            /// <summary>
            /// Snapchat
            /// </summary>
            public static IconUsage Snapchat => Get(0xf2ab);

            /// <summary>
            /// Snapchat Ghost
            /// </summary>
            public static IconUsage SnapchatGhost => Get(0xf2ac);

            /// <summary>
            /// Snapchat Square
            /// </summary>
            public static IconUsage SnapchatSquare => Get(0xf2ad);

            /// <summary>
            /// SoundCloud
            /// </summary>
            public static IconUsage Soundcloud => Get(0xf1be);

            /// <summary>
            /// Sourcetree
            /// </summary>
            public static IconUsage Sourcetree => Get(0xf7d3);

            /// <summary>
            /// Speakap
            /// </summary>
            public static IconUsage Speakap => Get(0xf3f3);

            /// <summary>
            /// Speaker Deck
            /// </summary>
            public static IconUsage SpeakerDeck => Get(0xf83c);

            /// <summary>
            /// Spotify
            /// </summary>
            public static IconUsage Spotify => Get(0xf1bc);

            /// <summary>
            /// Squarespace
            /// </summary>
            public static IconUsage Squarespace => Get(0xf5be);

            /// <summary>
            /// Stack Exchange
            /// </summary>
            public static IconUsage StackExchange => Get(0xf18d);

            /// <summary>
            /// Stack Overflow
            /// </summary>
            public static IconUsage StackOverflow => Get(0xf16c);

            /// <summary>
            /// StayLinked
            /// </summary>
            public static IconUsage Staylinked => Get(0xf3f5);

            /// <summary>
            /// Steam
            /// </summary>
            public static IconUsage Steam => Get(0xf1b6);

            /// <summary>
            /// Steam Square
            /// </summary>
            public static IconUsage SteamSquare => Get(0xf1b7);

            /// <summary>
            /// Steam Symbol
            /// </summary>
            public static IconUsage SteamSymbol => Get(0xf3f6);

            /// <summary>
            /// Sticker Mule
            /// </summary>
            public static IconUsage StickerMule => Get(0xf3f7);

            /// <summary>
            /// Strava
            /// </summary>
            public static IconUsage Strava => Get(0xf428);

            /// <summary>
            /// Stripe
            /// </summary>
            public static IconUsage Stripe => Get(0xf429);

            /// <summary>
            /// Stripe S
            /// </summary>
            public static IconUsage StripeS => Get(0xf42a);

            /// <summary>
            /// Studio Vinari
            /// </summary>
            public static IconUsage Studiovinari => Get(0xf3f8);

            /// <summary>
            /// StumbleUpon Logo
            /// </summary>
            public static IconUsage Stumbleupon => Get(0xf1a4);

            /// <summary>
            /// StumbleUpon Circle
            /// </summary>
            public static IconUsage StumbleuponCircle => Get(0xf1a3);

            /// <summary>
            /// Superpowers
            /// </summary>
            public static IconUsage Superpowers => Get(0xf2dd);

            /// <summary>
            /// Supple
            /// </summary>
            public static IconUsage Supple => Get(0xf3f9);

            /// <summary>
            /// Suse
            /// </summary>
            public static IconUsage Suse => Get(0xf7d6);

            /// <summary>
            /// Symfony
            /// </summary>
            public static IconUsage Symfony => Get(0xf83d);

            /// <summary>
            /// TeamSpeak
            /// </summary>
            public static IconUsage Teamspeak => Get(0xf4f9);

            /// <summary>
            /// Telegram
            /// </summary>
            public static IconUsage Telegram => Get(0xf2c6);

            /// <summary>
            /// Telegram Plane
            /// </summary>
            public static IconUsage TelegramPlane => Get(0xf3fe);

            /// <summary>
            /// Tencent Weibo
            /// </summary>
            public static IconUsage TencentWeibo => Get(0xf1d5);

            /// <summary>
            /// The Red Yeti
            /// </summary>
            public static IconUsage TheRedYeti => Get(0xf69d);

            /// <summary>
            /// Themeco
            /// </summary>
            public static IconUsage Themeco => Get(0xf5c6);

            /// <summary>
            /// ThemeIsle
            /// </summary>
            public static IconUsage Themeisle => Get(0xf2b2);

            /// <summary>
            /// Think Peaks
            /// </summary>
            public static IconUsage ThinkPeaks => Get(0xf731);

            /// <summary>
            /// Trade Federation
            /// </summary>
            public static IconUsage TradeFederation => Get(0xf513);

            /// <summary>
            /// Trello
            /// </summary>
            public static IconUsage Trello => Get(0xf181);

            /// <summary>
            /// TripAdvisor
            /// </summary>
            public static IconUsage Tripadvisor => Get(0xf262);

            /// <summary>
            /// Tumblr
            /// </summary>
            public static IconUsage Tumblr => Get(0xf173);

            /// <summary>
            /// Tumblr Square
            /// </summary>
            public static IconUsage TumblrSquare => Get(0xf174);

            /// <summary>
            /// Twitch
            /// </summary>
            public static IconUsage Twitch => Get(0xf1e8);

            /// <summary>
            /// Twitter
            /// </summary>
            public static IconUsage Twitter => Get(0xf099);

            /// <summary>
            /// Twitter Square
            /// </summary>
            public static IconUsage TwitterSquare => Get(0xf081);

            /// <summary>
            /// Typo3
            /// </summary>
            public static IconUsage Typo3 => Get(0xf42b);

            /// <summary>
            /// Uber
            /// </summary>
            public static IconUsage Uber => Get(0xf402);

            /// <summary>
            /// Ubuntu
            /// </summary>
            public static IconUsage Ubuntu => Get(0xf7df);

            /// <summary>
            /// UIkit
            /// </summary>
            public static IconUsage Uikit => Get(0xf403);

            /// <summary>
            /// Uniregistry
            /// </summary>
            public static IconUsage Uniregistry => Get(0xf404);

            /// <summary>
            /// Untappd
            /// </summary>
            public static IconUsage Untappd => Get(0xf405);

            /// <summary>
            /// UPS
            /// </summary>
            public static IconUsage Ups => Get(0xf7e0);

            /// <summary>
            /// USB
            /// </summary>
            public static IconUsage Usb => Get(0xf287);

            /// <summary>
            /// United States Postal Service
            /// </summary>
            public static IconUsage Usps => Get(0xf7e1);

            /// <summary>
            /// us-Sunnah Foundation
            /// </summary>
            public static IconUsage Ussunnah => Get(0xf407);

            /// <summary>
            /// Vaadin
            /// </summary>
            public static IconUsage Vaadin => Get(0xf408);

            /// <summary>
            /// Viacoin
            /// </summary>
            public static IconUsage Viacoin => Get(0xf237);

            /// <summary>
            /// Video
            /// </summary>
            public static IconUsage Viadeo => Get(0xf2a9);

            /// <summary>
            /// Video Square
            /// </summary>
            public static IconUsage ViadeoSquare => Get(0xf2aa);

            /// <summary>
            /// Viber
            /// </summary>
            public static IconUsage Viber => Get(0xf409);

            /// <summary>
            /// Vimeo
            /// </summary>
            public static IconUsage Vimeo => Get(0xf40a);

            /// <summary>
            /// Vimeo Square
            /// </summary>
            public static IconUsage VimeoSquare => Get(0xf194);

            /// <summary>
            /// Vimeo
            /// </summary>
            public static IconUsage VimeoV => Get(0xf27d);

            /// <summary>
            /// Vine
            /// </summary>
            public static IconUsage Vine => Get(0xf1ca);

            /// <summary>
            /// VK
            /// </summary>
            public static IconUsage Vk => Get(0xf189);

            /// <summary>
            /// VNV
            /// </summary>
            public static IconUsage Vnv => Get(0xf40b);

            /// <summary>
            /// Vue.js
            /// </summary>
            public static IconUsage Vuejs => Get(0xf41f);

            /// <summary>
            /// Waze
            /// </summary>
            public static IconUsage Waze => Get(0xf83f);

            /// <summary>
            /// Weebly
            /// </summary>
            public static IconUsage Weebly => Get(0xf5cc);

            /// <summary>
            /// Weibo
            /// </summary>
            public static IconUsage Weibo => Get(0xf18a);

            /// <summary>
            /// Weixin (WeChat)
            /// </summary>
            public static IconUsage Weixin => Get(0xf1d7);

            /// <summary>
            /// What's App
            /// </summary>
            public static IconUsage Whatsapp => Get(0xf232);

            /// <summary>
            /// What's App Square
            /// </summary>
            public static IconUsage WhatsappSquare => Get(0xf40c);

            /// <summary>
            /// WHMCS
            /// </summary>
            public static IconUsage Whmcs => Get(0xf40d);

            /// <summary>
            /// Wikipedia W
            /// </summary>
            public static IconUsage WikipediaW => Get(0xf266);

            /// <summary>
            /// Windows
            /// </summary>
            public static IconUsage Windows => Get(0xf17a);

            /// <summary>
            /// Wix
            /// </summary>
            public static IconUsage Wix => Get(0xf5cf);

            /// <summary>
            /// Wizards of the Coast
            /// </summary>
            public static IconUsage WizardsOfTheCoast => Get(0xf730);

            /// <summary>
            /// Wolf Pack Battalion
            /// </summary>
            public static IconUsage WolfPackBattalion => Get(0xf514);

            /// <summary>
            /// WordPress Logo
            /// </summary>
            public static IconUsage Wordpress => Get(0xf19a);

            /// <summary>
            /// Wordpress Simple
            /// </summary>
            public static IconUsage WordpressSimple => Get(0xf411);

            /// <summary>
            /// WPBeginner
            /// </summary>
            public static IconUsage Wpbeginner => Get(0xf297);

            /// <summary>
            /// WPExplorer
            /// </summary>
            public static IconUsage Wpexplorer => Get(0xf2de);

            /// <summary>
            /// WPForms
            /// </summary>
            public static IconUsage Wpforms => Get(0xf298);

            /// <summary>
            /// wpressr
            /// </summary>
            public static IconUsage Wpressr => Get(0xf3e4);

            /// <summary>
            /// Xbox
            /// </summary>
            public static IconUsage Xbox => Get(0xf412);

            /// <summary>
            /// Xing
            /// </summary>
            public static IconUsage Xing => Get(0xf168);

            /// <summary>
            /// Xing Square
            /// </summary>
            public static IconUsage XingSquare => Get(0xf169);

            /// <summary>
            /// Y Combinator
            /// </summary>
            public static IconUsage YCombinator => Get(0xf23b);

            /// <summary>
            /// Yahoo Logo
            /// </summary>
            public static IconUsage Yahoo => Get(0xf19e);

            /// <summary>
            /// Yammer
            /// </summary>
            public static IconUsage Yammer => Get(0xf840);

            /// <summary>
            /// Yandex
            /// </summary>
            public static IconUsage Yandex => Get(0xf413);

            /// <summary>
            /// Yandex International
            /// </summary>
            public static IconUsage YandexInternational => Get(0xf414);

            /// <summary>
            /// Yarn
            /// </summary>
            public static IconUsage Yarn => Get(0xf7e3);

            /// <summary>
            /// Yelp
            /// </summary>
            public static IconUsage Yelp => Get(0xf1e9);

            /// <summary>
            /// Yoast
            /// </summary>
            public static IconUsage Yoast => Get(0xf2b1);

            /// <summary>
            /// YouTube
            /// </summary>
            public static IconUsage Youtube => Get(0xf167);

            /// <summary>
            /// YouTube Square
            /// </summary>
            public static IconUsage YoutubeSquare => Get(0xf431);

            /// <summary>
            /// Zhihu
            /// </summary>
            public static IconUsage Zhihu => Get(0xf63f);
        }

        public static class Regular
        {
            public static IconUsage Get(int icon) => FontAwesome.Get(icon).With(weight: "Regular");

            /// <summary>
            /// Address Book
            /// </summary>
            public static IconUsage AddressBook => Get(0xf2b9);

            /// <summary>
            /// Address Card
            /// </summary>
            public static IconUsage AddressCard => Get(0xf2bb);

            /// <summary>
            /// Angry Face
            /// </summary>
            public static IconUsage Angry => Get(0xf556);

            /// <summary>
            /// Alternate Arrow Circle Down
            /// </summary>
            public static IconUsage ArrowAltCircleDown => Get(0xf358);

            /// <summary>
            /// Alternate Arrow Circle Left
            /// </summary>
            public static IconUsage ArrowAltCircleLeft => Get(0xf359);

            /// <summary>
            /// Alternate Arrow Circle Right
            /// </summary>
            public static IconUsage ArrowAltCircleRight => Get(0xf35a);

            /// <summary>
            /// Alternate Arrow Circle Up
            /// </summary>
            public static IconUsage ArrowAltCircleUp => Get(0xf35b);

            /// <summary>
            /// bell
            /// </summary>
            public static IconUsage Bell => Get(0xf0f3);

            /// <summary>
            /// Bell Slash
            /// </summary>
            public static IconUsage BellSlash => Get(0xf1f6);

            /// <summary>
            /// bookmark
            /// </summary>
            public static IconUsage Bookmark => Get(0xf02e);

            /// <summary>
            /// Building
            /// </summary>
            public static IconUsage Building => Get(0xf1ad);

            /// <summary>
            /// Calendar
            /// </summary>
            public static IconUsage Calendar => Get(0xf133);

            /// <summary>
            /// Alternate Calendar
            /// </summary>
            public static IconUsage CalendarAlt => Get(0xf073);

            /// <summary>
            /// Calendar Check
            /// </summary>
            public static IconUsage CalendarCheck => Get(0xf274);

            /// <summary>
            /// Calendar Minus
            /// </summary>
            public static IconUsage CalendarMinus => Get(0xf272);

            /// <summary>
            /// Calendar Plus
            /// </summary>
            public static IconUsage CalendarPlus => Get(0xf271);

            /// <summary>
            /// Calendar Times
            /// </summary>
            public static IconUsage CalendarTimes => Get(0xf273);

            /// <summary>
            /// Caret Square Down
            /// </summary>
            public static IconUsage CaretSquareDown => Get(0xf150);

            /// <summary>
            /// Caret Square Left
            /// </summary>
            public static IconUsage CaretSquareLeft => Get(0xf191);

            /// <summary>
            /// Caret Square Right
            /// </summary>
            public static IconUsage CaretSquareRight => Get(0xf152);

            /// <summary>
            /// Caret Square Up
            /// </summary>
            public static IconUsage CaretSquareUp => Get(0xf151);

            /// <summary>
            /// Bar Chart
            /// </summary>
            public static IconUsage ChartBar => Get(0xf080);

            /// <summary>
            /// Check Circle
            /// </summary>
            public static IconUsage CheckCircle => Get(0xf058);

            /// <summary>
            /// Check Square
            /// </summary>
            public static IconUsage CheckSquare => Get(0xf14a);

            /// <summary>
            /// Circle
            /// </summary>
            public static IconUsage Circle => Get(0xf111);

            /// <summary>
            /// Clipboard
            /// </summary>
            public static IconUsage Clipboard => Get(0xf328);

            /// <summary>
            /// Clock
            /// </summary>
            public static IconUsage Clock => Get(0xf017);

            /// <summary>
            /// Clone
            /// </summary>
            public static IconUsage Clone => Get(0xf24d);

            /// <summary>
            /// Closed Captioning
            /// </summary>
            public static IconUsage ClosedCaptioning => Get(0xf20a);

            /// <summary>
            /// comment
            /// </summary>
            public static IconUsage Comment => Get(0xf075);

            /// <summary>
            /// Alternate Comment
            /// </summary>
            public static IconUsage CommentAlt => Get(0xf27a);

            /// <summary>
            /// Comment Dots
            /// </summary>
            public static IconUsage CommentDots => Get(0xf4ad);

            /// <summary>
            /// comments
            /// </summary>
            public static IconUsage Comments => Get(0xf086);

            /// <summary>
            /// Compass
            /// </summary>
            public static IconUsage Compass => Get(0xf14e);

            /// <summary>
            /// Copy
            /// </summary>
            public static IconUsage Copy => Get(0xf0c5);

            /// <summary>
            /// Copyright
            /// </summary>
            public static IconUsage Copyright => Get(0xf1f9);

            /// <summary>
            /// Credit Card
            /// </summary>
            public static IconUsage CreditCard => Get(0xf09d);

            /// <summary>
            /// Dizzy Face
            /// </summary>
            public static IconUsage Dizzy => Get(0xf567);

            /// <summary>
            /// Dot Circle
            /// </summary>
            public static IconUsage DotCircle => Get(0xf192);

            /// <summary>
            /// Edit
            /// </summary>
            public static IconUsage Edit => Get(0xf044);

            /// <summary>
            /// Envelope
            /// </summary>
            public static IconUsage Envelope => Get(0xf0e0);

            /// <summary>
            /// Envelope Open
            /// </summary>
            public static IconUsage EnvelopeOpen => Get(0xf2b6);

            /// <summary>
            /// Eye
            /// </summary>
            public static IconUsage Eye => Get(0xf06e);

            /// <summary>
            /// Eye Slash
            /// </summary>
            public static IconUsage EyeSlash => Get(0xf070);

            /// <summary>
            /// File
            /// </summary>
            public static IconUsage File => Get(0xf15b);

            /// <summary>
            /// Alternate File
            /// </summary>
            public static IconUsage FileAlt => Get(0xf15c);

            /// <summary>
            /// Archive File
            /// </summary>
            public static IconUsage FileArchive => Get(0xf1c6);

            /// <summary>
            /// Audio File
            /// </summary>
            public static IconUsage FileAudio => Get(0xf1c7);

            /// <summary>
            /// Code File
            /// </summary>
            public static IconUsage FileCode => Get(0xf1c9);

            /// <summary>
            /// Excel File
            /// </summary>
            public static IconUsage FileExcel => Get(0xf1c3);

            /// <summary>
            /// Image File
            /// </summary>
            public static IconUsage FileImage => Get(0xf1c5);

            /// <summary>
            /// PDF File
            /// </summary>
            public static IconUsage FilePdf => Get(0xf1c1);

            /// <summary>
            /// Powerpoint File
            /// </summary>
            public static IconUsage FilePowerpoint => Get(0xf1c4);

            /// <summary>
            /// Video File
            /// </summary>
            public static IconUsage FileVideo => Get(0xf1c8);

            /// <summary>
            /// Word File
            /// </summary>
            public static IconUsage FileWord => Get(0xf1c2);

            /// <summary>
            /// flag
            /// </summary>
            public static IconUsage Flag => Get(0xf024);

            /// <summary>
            /// Flushed Face
            /// </summary>
            public static IconUsage Flushed => Get(0xf579);

            /// <summary>
            /// Folder
            /// </summary>
            public static IconUsage Folder => Get(0xf07b);

            /// <summary>
            /// Folder Open
            /// </summary>
            public static IconUsage FolderOpen => Get(0xf07c);

            /// <summary>
            /// Font Awesome Full Logo
            /// </summary>
            public static IconUsage FontAwesomeLogoFull => Get(0xf4e6);

            /// <summary>
            /// Frowning Face
            /// </summary>
            public static IconUsage Frown => Get(0xf119);

            /// <summary>
            /// Frowning Face With Open Mouth
            /// </summary>
            public static IconUsage FrownOpen => Get(0xf57a);

            /// <summary>
            /// Futbol
            /// </summary>
            public static IconUsage Futbol => Get(0xf1e3);

            /// <summary>
            /// Gem
            /// </summary>
            public static IconUsage Gem => Get(0xf3a5);

            /// <summary>
            /// Grimacing Face
            /// </summary>
            public static IconUsage Grimace => Get(0xf57f);

            /// <summary>
            /// Grinning Face
            /// </summary>
            public static IconUsage Grin => Get(0xf580);

            /// <summary>
            /// Alternate Grinning Face
            /// </summary>
            public static IconUsage GrinAlt => Get(0xf581);

            /// <summary>
            /// Grinning Face With Smiling Eyes
            /// </summary>
            public static IconUsage GrinBeam => Get(0xf582);

            /// <summary>
            /// Grinning Face With Sweat
            /// </summary>
            public static IconUsage GrinBeamSweat => Get(0xf583);

            /// <summary>
            /// Smiling Face With Heart-Eyes
            /// </summary>
            public static IconUsage GrinHearts => Get(0xf584);

            /// <summary>
            /// Grinning Squinting Face
            /// </summary>
            public static IconUsage GrinSquint => Get(0xf585);

            /// <summary>
            /// Rolling on the Floor Laughing
            /// </summary>
            public static IconUsage GrinSquintTears => Get(0xf586);

            /// <summary>
            /// Star-Struck
            /// </summary>
            public static IconUsage GrinStars => Get(0xf587);

            /// <summary>
            /// Face With Tears of Joy
            /// </summary>
            public static IconUsage GrinTears => Get(0xf588);

            /// <summary>
            /// Face With Tongue
            /// </summary>
            public static IconUsage GrinTongue => Get(0xf589);

            /// <summary>
            /// Squinting Face With Tongue
            /// </summary>
            public static IconUsage GrinTongueSquint => Get(0xf58a);

            /// <summary>
            /// Winking Face With Tongue
            /// </summary>
            public static IconUsage GrinTongueWink => Get(0xf58b);

            /// <summary>
            /// Grinning Winking Face
            /// </summary>
            public static IconUsage GrinWink => Get(0xf58c);

            /// <summary>
            /// Lizard (Hand)
            /// </summary>
            public static IconUsage HandLizard => Get(0xf258);

            /// <summary>
            /// Paper (Hand)
            /// </summary>
            public static IconUsage HandPaper => Get(0xf256);

            /// <summary>
            /// Peace (Hand)
            /// </summary>
            public static IconUsage HandPeace => Get(0xf25b);

            /// <summary>
            /// Hand Pointing Down
            /// </summary>
            public static IconUsage HandPointDown => Get(0xf0a7);

            /// <summary>
            /// Hand Pointing Left
            /// </summary>
            public static IconUsage HandPointLeft => Get(0xf0a5);

            /// <summary>
            /// Hand Pointing Right
            /// </summary>
            public static IconUsage HandPointRight => Get(0xf0a4);

            /// <summary>
            /// Hand Pointing Up
            /// </summary>
            public static IconUsage HandPointUp => Get(0xf0a6);

            /// <summary>
            /// Pointer (Hand)
            /// </summary>
            public static IconUsage HandPointer => Get(0xf25a);

            /// <summary>
            /// Rock (Hand)
            /// </summary>
            public static IconUsage HandRock => Get(0xf255);

            /// <summary>
            /// Scissors (Hand)
            /// </summary>
            public static IconUsage HandScissors => Get(0xf257);

            /// <summary>
            /// Spock (Hand)
            /// </summary>
            public static IconUsage HandSpock => Get(0xf259);

            /// <summary>
            /// Handshake
            /// </summary>
            public static IconUsage Handshake => Get(0xf2b5);

            /// <summary>
            /// HDD
            /// </summary>
            public static IconUsage Hdd => Get(0xf0a0);

            /// <summary>
            /// Heart
            /// </summary>
            public static IconUsage Heart => Get(0xf004);

            /// <summary>
            /// hospital
            /// </summary>
            public static IconUsage Hospital => Get(0xf0f8);

            /// <summary>
            /// Hourglass
            /// </summary>
            public static IconUsage Hourglass => Get(0xf254);

            /// <summary>
            /// Identification Badge
            /// </summary>
            public static IconUsage IdBadge => Get(0xf2c1);

            /// <summary>
            /// Identification Card
            /// </summary>
            public static IconUsage IdCard => Get(0xf2c2);

            /// <summary>
            /// Image
            /// </summary>
            public static IconUsage Image => Get(0xf03e);

            /// <summary>
            /// Images
            /// </summary>
            public static IconUsage Images => Get(0xf302);

            /// <summary>
            /// Keyboard
            /// </summary>
            public static IconUsage Keyboard => Get(0xf11c);

            /// <summary>
            /// Kissing Face
            /// </summary>
            public static IconUsage Kiss => Get(0xf596);

            /// <summary>
            /// Kissing Face With Smiling Eyes
            /// </summary>
            public static IconUsage KissBeam => Get(0xf597);

            /// <summary>
            /// Face Blowing a Kiss
            /// </summary>
            public static IconUsage KissWinkHeart => Get(0xf598);

            /// <summary>
            /// Grinning Face With Big Eyes
            /// </summary>
            public static IconUsage Laugh => Get(0xf599);

            /// <summary>
            /// Laugh Face with Beaming Eyes
            /// </summary>
            public static IconUsage LaughBeam => Get(0xf59a);

            /// <summary>
            /// Laughing Squinting Face
            /// </summary>
            public static IconUsage LaughSquint => Get(0xf59b);

            /// <summary>
            /// Laughing Winking Face
            /// </summary>
            public static IconUsage LaughWink => Get(0xf59c);

            /// <summary>
            /// Lemon
            /// </summary>
            public static IconUsage Lemon => Get(0xf094);

            /// <summary>
            /// Life Ring
            /// </summary>
            public static IconUsage LifeRing => Get(0xf1cd);

            /// <summary>
            /// Lightbulb
            /// </summary>
            public static IconUsage Lightbulb => Get(0xf0eb);

            /// <summary>
            /// Alternate List
            /// </summary>
            public static IconUsage ListAlt => Get(0xf022);

            /// <summary>
            /// Map
            /// </summary>
            public static IconUsage Map => Get(0xf279);

            /// <summary>
            /// Neutral Face
            /// </summary>
            public static IconUsage Meh => Get(0xf11a);

            /// <summary>
            /// Face Without Mouth
            /// </summary>
            public static IconUsage MehBlank => Get(0xf5a4);

            /// <summary>
            /// Face With Rolling Eyes
            /// </summary>
            public static IconUsage MehRollingEyes => Get(0xf5a5);

            /// <summary>
            /// Minus Square
            /// </summary>
            public static IconUsage MinusSquare => Get(0xf146);

            /// <summary>
            /// Alternate Money Bill
            /// </summary>
            public static IconUsage MoneyBillAlt => Get(0xf3d1);

            /// <summary>
            /// Moon
            /// </summary>
            public static IconUsage Moon => Get(0xf186);

            /// <summary>
            /// Newspaper
            /// </summary>
            public static IconUsage Newspaper => Get(0xf1ea);

            /// <summary>
            /// Object Group
            /// </summary>
            public static IconUsage ObjectGroup => Get(0xf247);

            /// <summary>
            /// Object Ungroup
            /// </summary>
            public static IconUsage ObjectUngroup => Get(0xf248);

            /// <summary>
            /// Paper Plane
            /// </summary>
            public static IconUsage PaperPlane => Get(0xf1d8);

            /// <summary>
            /// Pause Circle
            /// </summary>
            public static IconUsage PauseCircle => Get(0xf28b);

            /// <summary>
            /// Play Circle
            /// </summary>
            public static IconUsage PlayCircle => Get(0xf144);

            /// <summary>
            /// Plus Square
            /// </summary>
            public static IconUsage PlusSquare => Get(0xf0fe);

            /// <summary>
            /// Question Circle
            /// </summary>
            public static IconUsage QuestionCircle => Get(0xf059);

            /// <summary>
            /// Registered Trademark
            /// </summary>
            public static IconUsage Registered => Get(0xf25d);

            /// <summary>
            /// Crying Face
            /// </summary>
            public static IconUsage SadCry => Get(0xf5b3);

            /// <summary>
            /// Loudly Crying Face
            /// </summary>
            public static IconUsage SadTear => Get(0xf5b4);

            /// <summary>
            /// Save
            /// </summary>
            public static IconUsage Save => Get(0xf0c7);

            /// <summary>
            /// Share Square
            /// </summary>
            public static IconUsage ShareSquare => Get(0xf14d);

            /// <summary>
            /// Smiling Face
            /// </summary>
            public static IconUsage Smile => Get(0xf118);

            /// <summary>
            /// Beaming Face With Smiling Eyes
            /// </summary>
            public static IconUsage SmileBeam => Get(0xf5b8);

            /// <summary>
            /// Winking Face
            /// </summary>
            public static IconUsage SmileWink => Get(0xf4da);

            /// <summary>
            /// Snowflake
            /// </summary>
            public static IconUsage Snowflake => Get(0xf2dc);

            /// <summary>
            /// Square
            /// </summary>
            public static IconUsage Square => Get(0xf0c8);

            /// <summary>
            /// Star
            /// </summary>
            public static IconUsage Star => Get(0xf005);

            /// <summary>
            /// star-half
            /// </summary>
            public static IconUsage StarHalf => Get(0xf089);

            /// <summary>
            /// Sticky Note
            /// </summary>
            public static IconUsage StickyNote => Get(0xf249);

            /// <summary>
            /// Stop Circle
            /// </summary>
            public static IconUsage StopCircle => Get(0xf28d);

            /// <summary>
            /// Sun
            /// </summary>
            public static IconUsage Sun => Get(0xf185);

            /// <summary>
            /// Hushed Face
            /// </summary>
            public static IconUsage Surprise => Get(0xf5c2);

            /// <summary>
            /// thumbs-down
            /// </summary>
            public static IconUsage ThumbsDown => Get(0xf165);

            /// <summary>
            /// thumbs-up
            /// </summary>
            public static IconUsage ThumbsUp => Get(0xf164);

            /// <summary>
            /// Times Circle
            /// </summary>
            public static IconUsage TimesCircle => Get(0xf057);

            /// <summary>
            /// Tired Face
            /// </summary>
            public static IconUsage Tired => Get(0xf5c8);

            /// <summary>
            /// Alternate Trash
            /// </summary>
            public static IconUsage TrashAlt => Get(0xf2ed);

            /// <summary>
            /// User
            /// </summary>
            public static IconUsage User => Get(0xf007);

            /// <summary>
            /// User Circle
            /// </summary>
            public static IconUsage UserCircle => Get(0xf2bd);

            /// <summary>
            /// Window Close
            /// </summary>
            public static IconUsage WindowClose => Get(0xf410);

            /// <summary>
            /// Window Maximize
            /// </summary>
            public static IconUsage WindowMaximize => Get(0xf2d0);

            /// <summary>
            /// Window Minimize
            /// </summary>
            public static IconUsage WindowMinimize => Get(0xf2d1);

            /// <summary>
            /// Window Restore
            /// </summary>
            public static IconUsage WindowRestore => Get(0xf2d2);
        }

        public static class Solid
        {
            public static IconUsage Get(int icon) => FontAwesome.Get(icon).With(weight: "Solid");

            /// <summary>
            /// Ad
            /// </summary>
            public static IconUsage Ad => Get(0xf641);

            /// <summary>
            /// Address Book
            /// </summary>
            public static IconUsage AddressBook => Get(0xf2b9);

            /// <summary>
            /// Address Card
            /// </summary>
            public static IconUsage AddressCard => Get(0xf2bb);

            /// <summary>
            /// adjust
            /// </summary>
            public static IconUsage Adjust => Get(0xf042);

            /// <summary>
            /// Air Freshener
            /// </summary>
            public static IconUsage AirFreshener => Get(0xf5d0);

            /// <summary>
            /// align-center
            /// </summary>
            public static IconUsage AlignCenter => Get(0xf037);

            /// <summary>
            /// align-justify
            /// </summary>
            public static IconUsage AlignJustify => Get(0xf039);

            /// <summary>
            /// align-left
            /// </summary>
            public static IconUsage AlignLeft => Get(0xf036);

            /// <summary>
            /// align-right
            /// </summary>
            public static IconUsage AlignRight => Get(0xf038);

            /// <summary>
            /// Allergies
            /// </summary>
            public static IconUsage Allergies => Get(0xf461);

            /// <summary>
            /// ambulance
            /// </summary>
            public static IconUsage Ambulance => Get(0xf0f9);

            /// <summary>
            /// American Sign Language Interpreting
            /// </summary>
            public static IconUsage AmericanSignLanguageInterpreting => Get(0xf2a3);

            /// <summary>
            /// Anchor
            /// </summary>
            public static IconUsage Anchor => Get(0xf13d);

            /// <summary>
            /// Angle Double Down
            /// </summary>
            public static IconUsage AngleDoubleDown => Get(0xf103);

            /// <summary>
            /// Angle Double Left
            /// </summary>
            public static IconUsage AngleDoubleLeft => Get(0xf100);

            /// <summary>
            /// Angle Double Right
            /// </summary>
            public static IconUsage AngleDoubleRight => Get(0xf101);

            /// <summary>
            /// Angle Double Up
            /// </summary>
            public static IconUsage AngleDoubleUp => Get(0xf102);

            /// <summary>
            /// angle-down
            /// </summary>
            public static IconUsage AngleDown => Get(0xf107);

            /// <summary>
            /// angle-left
            /// </summary>
            public static IconUsage AngleLeft => Get(0xf104);

            /// <summary>
            /// angle-right
            /// </summary>
            public static IconUsage AngleRight => Get(0xf105);

            /// <summary>
            /// angle-up
            /// </summary>
            public static IconUsage AngleUp => Get(0xf106);

            /// <summary>
            /// Angry Face
            /// </summary>
            public static IconUsage Angry => Get(0xf556);

            /// <summary>
            /// Ankh
            /// </summary>
            public static IconUsage Ankh => Get(0xf644);

            /// <summary>
            /// Fruit Apple
            /// </summary>
            public static IconUsage AppleAlt => Get(0xf5d1);

            /// <summary>
            /// Archive
            /// </summary>
            public static IconUsage Archive => Get(0xf187);

            /// <summary>
            /// Archway
            /// </summary>
            public static IconUsage Archway => Get(0xf557);

            /// <summary>
            /// Alternate Arrow Circle Down
            /// </summary>
            public static IconUsage ArrowAltCircleDown => Get(0xf358);

            /// <summary>
            /// Alternate Arrow Circle Left
            /// </summary>
            public static IconUsage ArrowAltCircleLeft => Get(0xf359);

            /// <summary>
            /// Alternate Arrow Circle Right
            /// </summary>
            public static IconUsage ArrowAltCircleRight => Get(0xf35a);

            /// <summary>
            /// Alternate Arrow Circle Up
            /// </summary>
            public static IconUsage ArrowAltCircleUp => Get(0xf35b);

            /// <summary>
            /// Arrow Circle Down
            /// </summary>
            public static IconUsage ArrowCircleDown => Get(0xf0ab);

            /// <summary>
            /// Arrow Circle Left
            /// </summary>
            public static IconUsage ArrowCircleLeft => Get(0xf0a8);

            /// <summary>
            /// Arrow Circle Right
            /// </summary>
            public static IconUsage ArrowCircleRight => Get(0xf0a9);

            /// <summary>
            /// Arrow Circle Up
            /// </summary>
            public static IconUsage ArrowCircleUp => Get(0xf0aa);

            /// <summary>
            /// arrow-down
            /// </summary>
            public static IconUsage ArrowDown => Get(0xf063);

            /// <summary>
            /// arrow-left
            /// </summary>
            public static IconUsage ArrowLeft => Get(0xf060);

            /// <summary>
            /// arrow-right
            /// </summary>
            public static IconUsage ArrowRight => Get(0xf061);

            /// <summary>
            /// arrow-up
            /// </summary>
            public static IconUsage ArrowUp => Get(0xf062);

            /// <summary>
            /// Alternate Arrows
            /// </summary>
            public static IconUsage ArrowsAlt => Get(0xf0b2);

            /// <summary>
            /// Alternate Arrows Horizontal
            /// </summary>
            public static IconUsage ArrowsAltH => Get(0xf337);

            /// <summary>
            /// Alternate Arrows Vertical
            /// </summary>
            public static IconUsage ArrowsAltV => Get(0xf338);

            /// <summary>
            /// Assistive Listening Systems
            /// </summary>
            public static IconUsage AssistiveListeningSystems => Get(0xf2a2);

            /// <summary>
            /// asterisk
            /// </summary>
            public static IconUsage Asterisk => Get(0xf069);

            /// <summary>
            /// At
            /// </summary>
            public static IconUsage At => Get(0xf1fa);

            /// <summary>
            /// Atlas
            /// </summary>
            public static IconUsage Atlas => Get(0xf558);

            /// <summary>
            /// Atom
            /// </summary>
            public static IconUsage Atom => Get(0xf5d2);

            /// <summary>
            /// Audio Description
            /// </summary>
            public static IconUsage AudioDescription => Get(0xf29e);

            /// <summary>
            /// Award
            /// </summary>
            public static IconUsage Award => Get(0xf559);

            /// <summary>
            /// Baby
            /// </summary>
            public static IconUsage Baby => Get(0xf77c);

            /// <summary>
            /// Baby Carriage
            /// </summary>
            public static IconUsage BabyCarriage => Get(0xf77d);

            /// <summary>
            /// Backspace
            /// </summary>
            public static IconUsage Backspace => Get(0xf55a);

            /// <summary>
            /// backward
            /// </summary>
            public static IconUsage Backward => Get(0xf04a);

            /// <summary>
            /// Bacon
            /// </summary>
            public static IconUsage Bacon => Get(0xf7e5);

            /// <summary>
            /// Balance Scale
            /// </summary>
            public static IconUsage BalanceScale => Get(0xf24e);

            /// <summary>
            /// ban
            /// </summary>
            public static IconUsage Ban => Get(0xf05e);

            /// <summary>
            /// Band-Aid
            /// </summary>
            public static IconUsage BandAid => Get(0xf462);

            /// <summary>
            /// barcode
            /// </summary>
            public static IconUsage Barcode => Get(0xf02a);

            /// <summary>
            /// Bars
            /// </summary>
            public static IconUsage Bars => Get(0xf0c9);

            /// <summary>
            /// Baseball Ball
            /// </summary>
            public static IconUsage BaseballBall => Get(0xf433);

            /// <summary>
            /// Basketball Ball
            /// </summary>
            public static IconUsage BasketballBall => Get(0xf434);

            /// <summary>
            /// Bath
            /// </summary>
            public static IconUsage Bath => Get(0xf2cd);

            /// <summary>
            /// Battery Empty
            /// </summary>
            public static IconUsage BatteryEmpty => Get(0xf244);

            /// <summary>
            /// Battery Full
            /// </summary>
            public static IconUsage BatteryFull => Get(0xf240);

            /// <summary>
            /// Battery 1/2 Full
            /// </summary>
            public static IconUsage BatteryHalf => Get(0xf242);

            /// <summary>
            /// Battery 1/4 Full
            /// </summary>
            public static IconUsage BatteryQuarter => Get(0xf243);

            /// <summary>
            /// Battery 3/4 Full
            /// </summary>
            public static IconUsage BatteryThreeQuarters => Get(0xf241);

            /// <summary>
            /// Bed
            /// </summary>
            public static IconUsage Bed => Get(0xf236);

            /// <summary>
            /// beer
            /// </summary>
            public static IconUsage Beer => Get(0xf0fc);

            /// <summary>
            /// bell
            /// </summary>
            public static IconUsage Bell => Get(0xf0f3);

            /// <summary>
            /// Bell Slash
            /// </summary>
            public static IconUsage BellSlash => Get(0xf1f6);

            /// <summary>
            /// Bezier Curve
            /// </summary>
            public static IconUsage BezierCurve => Get(0xf55b);

            /// <summary>
            /// Bible
            /// </summary>
            public static IconUsage Bible => Get(0xf647);

            /// <summary>
            /// Bicycle
            /// </summary>
            public static IconUsage Bicycle => Get(0xf206);

            /// <summary>
            /// Binoculars
            /// </summary>
            public static IconUsage Binoculars => Get(0xf1e5);

            /// <summary>
            /// Biohazard
            /// </summary>
            public static IconUsage Biohazard => Get(0xf780);

            /// <summary>
            /// Birthday Cake
            /// </summary>
            public static IconUsage BirthdayCake => Get(0xf1fd);

            /// <summary>
            /// Blender
            /// </summary>
            public static IconUsage Blender => Get(0xf517);

            /// <summary>
            /// Blender Phone
            /// </summary>
            public static IconUsage BlenderPhone => Get(0xf6b6);

            /// <summary>
            /// Blind
            /// </summary>
            public static IconUsage Blind => Get(0xf29d);

            /// <summary>
            /// Blog
            /// </summary>
            public static IconUsage Blog => Get(0xf781);

            /// <summary>
            /// bold
            /// </summary>
            public static IconUsage Bold => Get(0xf032);

            /// <summary>
            /// Lightning Bolt
            /// </summary>
            public static IconUsage Bolt => Get(0xf0e7);

            /// <summary>
            /// Bomb
            /// </summary>
            public static IconUsage Bomb => Get(0xf1e2);

            /// <summary>
            /// Bone
            /// </summary>
            public static IconUsage Bone => Get(0xf5d7);

            /// <summary>
            /// Bong
            /// </summary>
            public static IconUsage Bong => Get(0xf55c);

            /// <summary>
            /// book
            /// </summary>
            public static IconUsage Book => Get(0xf02d);

            /// <summary>
            /// Book of the Dead
            /// </summary>
            public static IconUsage BookDead => Get(0xf6b7);

            /// <summary>
            /// Medical Book
            /// </summary>
            public static IconUsage BookMedical => Get(0xf7e6);

            /// <summary>
            /// Book Open
            /// </summary>
            public static IconUsage BookOpen => Get(0xf518);

            /// <summary>
            /// Book Reader
            /// </summary>
            public static IconUsage BookReader => Get(0xf5da);

            /// <summary>
            /// bookmark
            /// </summary>
            public static IconUsage Bookmark => Get(0xf02e);

            /// <summary>
            /// Bowling Ball
            /// </summary>
            public static IconUsage BowlingBall => Get(0xf436);

            /// <summary>
            /// Box
            /// </summary>
            public static IconUsage Box => Get(0xf466);

            /// <summary>
            /// Box Open
            /// </summary>
            public static IconUsage BoxOpen => Get(0xf49e);

            /// <summary>
            /// Boxes
            /// </summary>
            public static IconUsage Boxes => Get(0xf468);

            /// <summary>
            /// Braille
            /// </summary>
            public static IconUsage Braille => Get(0xf2a1);

            /// <summary>
            /// Brain
            /// </summary>
            public static IconUsage Brain => Get(0xf5dc);

            /// <summary>
            /// Bread Slice
            /// </summary>
            public static IconUsage BreadSlice => Get(0xf7ec);

            /// <summary>
            /// Briefcase
            /// </summary>
            public static IconUsage Briefcase => Get(0xf0b1);

            /// <summary>
            /// Medical Briefcase
            /// </summary>
            public static IconUsage BriefcaseMedical => Get(0xf469);

            /// <summary>
            /// Broadcast Tower
            /// </summary>
            public static IconUsage BroadcastTower => Get(0xf519);

            /// <summary>
            /// Broom
            /// </summary>
            public static IconUsage Broom => Get(0xf51a);

            /// <summary>
            /// Brush
            /// </summary>
            public static IconUsage Brush => Get(0xf55d);

            /// <summary>
            /// Bug
            /// </summary>
            public static IconUsage Bug => Get(0xf188);

            /// <summary>
            /// Building
            /// </summary>
            public static IconUsage Building => Get(0xf1ad);

            /// <summary>
            /// bullhorn
            /// </summary>
            public static IconUsage Bullhorn => Get(0xf0a1);

            /// <summary>
            /// Bullseye
            /// </summary>
            public static IconUsage Bullseye => Get(0xf140);

            /// <summary>
            /// Burn
            /// </summary>
            public static IconUsage Burn => Get(0xf46a);

            /// <summary>
            /// Bus
            /// </summary>
            public static IconUsage Bus => Get(0xf207);

            /// <summary>
            /// Bus Alt
            /// </summary>
            public static IconUsage BusAlt => Get(0xf55e);

            /// <summary>
            /// Business Time
            /// </summary>
            public static IconUsage BusinessTime => Get(0xf64a);

            /// <summary>
            /// Calculator
            /// </summary>
            public static IconUsage Calculator => Get(0xf1ec);

            /// <summary>
            /// Calendar
            /// </summary>
            public static IconUsage Calendar => Get(0xf133);

            /// <summary>
            /// Alternate Calendar
            /// </summary>
            public static IconUsage CalendarAlt => Get(0xf073);

            /// <summary>
            /// Calendar Check
            /// </summary>
            public static IconUsage CalendarCheck => Get(0xf274);

            /// <summary>
            /// Calendar with Day Focus
            /// </summary>
            public static IconUsage CalendarDay => Get(0xf783);

            /// <summary>
            /// Calendar Minus
            /// </summary>
            public static IconUsage CalendarMinus => Get(0xf272);

            /// <summary>
            /// Calendar Plus
            /// </summary>
            public static IconUsage CalendarPlus => Get(0xf271);

            /// <summary>
            /// Calendar Times
            /// </summary>
            public static IconUsage CalendarTimes => Get(0xf273);

            /// <summary>
            /// Calendar with Week Focus
            /// </summary>
            public static IconUsage CalendarWeek => Get(0xf784);

            /// <summary>
            /// camera
            /// </summary>
            public static IconUsage Camera => Get(0xf030);

            /// <summary>
            /// Retro Camera
            /// </summary>
            public static IconUsage CameraRetro => Get(0xf083);

            /// <summary>
            /// Campground
            /// </summary>
            public static IconUsage Campground => Get(0xf6bb);

            /// <summary>
            /// Candy Cane
            /// </summary>
            public static IconUsage CandyCane => Get(0xf786);

            /// <summary>
            /// Cannabis
            /// </summary>
            public static IconUsage Cannabis => Get(0xf55f);

            /// <summary>
            /// Capsules
            /// </summary>
            public static IconUsage Capsules => Get(0xf46b);

            /// <summary>
            /// Car
            /// </summary>
            public static IconUsage Car => Get(0xf1b9);

            /// <summary>
            /// Alternate Car
            /// </summary>
            public static IconUsage CarAlt => Get(0xf5de);

            /// <summary>
            /// Car Battery
            /// </summary>
            public static IconUsage CarBattery => Get(0xf5df);

            /// <summary>
            /// Car Crash
            /// </summary>
            public static IconUsage CarCrash => Get(0xf5e1);

            /// <summary>
            /// Car Side
            /// </summary>
            public static IconUsage CarSide => Get(0xf5e4);

            /// <summary>
            /// Caret Down
            /// </summary>
            public static IconUsage CaretDown => Get(0xf0d7);

            /// <summary>
            /// Caret Left
            /// </summary>
            public static IconUsage CaretLeft => Get(0xf0d9);

            /// <summary>
            /// Caret Right
            /// </summary>
            public static IconUsage CaretRight => Get(0xf0da);

            /// <summary>
            /// Caret Square Down
            /// </summary>
            public static IconUsage CaretSquareDown => Get(0xf150);

            /// <summary>
            /// Caret Square Left
            /// </summary>
            public static IconUsage CaretSquareLeft => Get(0xf191);

            /// <summary>
            /// Caret Square Right
            /// </summary>
            public static IconUsage CaretSquareRight => Get(0xf152);

            /// <summary>
            /// Caret Square Up
            /// </summary>
            public static IconUsage CaretSquareUp => Get(0xf151);

            /// <summary>
            /// Caret Up
            /// </summary>
            public static IconUsage CaretUp => Get(0xf0d8);

            /// <summary>
            /// Carrot
            /// </summary>
            public static IconUsage Carrot => Get(0xf787);

            /// <summary>
            /// Shopping Cart Arrow Down
            /// </summary>
            public static IconUsage CartArrowDown => Get(0xf218);

            /// <summary>
            /// Add to Shopping Cart
            /// </summary>
            public static IconUsage CartPlus => Get(0xf217);

            /// <summary>
            /// Cash Register
            /// </summary>
            public static IconUsage CashRegister => Get(0xf788);

            /// <summary>
            /// Cat
            /// </summary>
            public static IconUsage Cat => Get(0xf6be);

            /// <summary>
            /// certificate
            /// </summary>
            public static IconUsage Certificate => Get(0xf0a3);

            /// <summary>
            /// Chair
            /// </summary>
            public static IconUsage Chair => Get(0xf6c0);

            /// <summary>
            /// Chalkboard
            /// </summary>
            public static IconUsage Chalkboard => Get(0xf51b);

            /// <summary>
            /// Chalkboard Teacher
            /// </summary>
            public static IconUsage ChalkboardTeacher => Get(0xf51c);

            /// <summary>
            /// Charging Station
            /// </summary>
            public static IconUsage ChargingStation => Get(0xf5e7);

            /// <summary>
            /// Area Chart
            /// </summary>
            public static IconUsage ChartArea => Get(0xf1fe);

            /// <summary>
            /// Bar Chart
            /// </summary>
            public static IconUsage ChartBar => Get(0xf080);

            /// <summary>
            /// Line Chart
            /// </summary>
            public static IconUsage ChartLine => Get(0xf201);

            /// <summary>
            /// Pie Chart
            /// </summary>
            public static IconUsage ChartPie => Get(0xf200);

            /// <summary>
            /// Check
            /// </summary>
            public static IconUsage Check => Get(0xf00c);

            /// <summary>
            /// Check Circle
            /// </summary>
            public static IconUsage CheckCircle => Get(0xf058);

            /// <summary>
            /// Check Double
            /// </summary>
            public static IconUsage CheckDouble => Get(0xf560);

            /// <summary>
            /// Check Square
            /// </summary>
            public static IconUsage CheckSquare => Get(0xf14a);

            /// <summary>
            /// Cheese
            /// </summary>
            public static IconUsage Cheese => Get(0xf7ef);

            /// <summary>
            /// Chess
            /// </summary>
            public static IconUsage Chess => Get(0xf439);

            /// <summary>
            /// Chess Bishop
            /// </summary>
            public static IconUsage ChessBishop => Get(0xf43a);

            /// <summary>
            /// Chess Board
            /// </summary>
            public static IconUsage ChessBoard => Get(0xf43c);

            /// <summary>
            /// Chess King
            /// </summary>
            public static IconUsage ChessKing => Get(0xf43f);

            /// <summary>
            /// Chess Knight
            /// </summary>
            public static IconUsage ChessKnight => Get(0xf441);

            /// <summary>
            /// Chess Pawn
            /// </summary>
            public static IconUsage ChessPawn => Get(0xf443);

            /// <summary>
            /// Chess Queen
            /// </summary>
            public static IconUsage ChessQueen => Get(0xf445);

            /// <summary>
            /// Chess Rook
            /// </summary>
            public static IconUsage ChessRook => Get(0xf447);

            /// <summary>
            /// Chevron Circle Down
            /// </summary>
            public static IconUsage ChevronCircleDown => Get(0xf13a);

            /// <summary>
            /// Chevron Circle Left
            /// </summary>
            public static IconUsage ChevronCircleLeft => Get(0xf137);

            /// <summary>
            /// Chevron Circle Right
            /// </summary>
            public static IconUsage ChevronCircleRight => Get(0xf138);

            /// <summary>
            /// Chevron Circle Up
            /// </summary>
            public static IconUsage ChevronCircleUp => Get(0xf139);

            /// <summary>
            /// chevron-down
            /// </summary>
            public static IconUsage ChevronDown => Get(0xf078);

            /// <summary>
            /// chevron-left
            /// </summary>
            public static IconUsage ChevronLeft => Get(0xf053);

            /// <summary>
            /// chevron-right
            /// </summary>
            public static IconUsage ChevronRight => Get(0xf054);

            /// <summary>
            /// chevron-up
            /// </summary>
            public static IconUsage ChevronUp => Get(0xf077);

            /// <summary>
            /// Child
            /// </summary>
            public static IconUsage Child => Get(0xf1ae);

            /// <summary>
            /// Church
            /// </summary>
            public static IconUsage Church => Get(0xf51d);

            /// <summary>
            /// Circle
            /// </summary>
            public static IconUsage Circle => Get(0xf111);

            /// <summary>
            /// Circle Notched
            /// </summary>
            public static IconUsage CircleNotch => Get(0xf1ce);

            /// <summary>
            /// City
            /// </summary>
            public static IconUsage City => Get(0xf64f);

            /// <summary>
            /// Medical Clinic
            /// </summary>
            public static IconUsage ClinicMedical => Get(0xf7f2);

            /// <summary>
            /// Clipboard
            /// </summary>
            public static IconUsage Clipboard => Get(0xf328);

            /// <summary>
            /// Clipboard with Check
            /// </summary>
            public static IconUsage ClipboardCheck => Get(0xf46c);

            /// <summary>
            /// Clipboard List
            /// </summary>
            public static IconUsage ClipboardList => Get(0xf46d);

            /// <summary>
            /// Clock
            /// </summary>
            public static IconUsage Clock => Get(0xf017);

            /// <summary>
            /// Clone
            /// </summary>
            public static IconUsage Clone => Get(0xf24d);

            /// <summary>
            /// Closed Captioning
            /// </summary>
            public static IconUsage ClosedCaptioning => Get(0xf20a);

            /// <summary>
            /// Cloud
            /// </summary>
            public static IconUsage Cloud => Get(0xf0c2);

            /// <summary>
            /// Alternate Cloud Download
            /// </summary>
            public static IconUsage CloudDownloadAlt => Get(0xf381);

            /// <summary>
            /// Cloud with (a chance of) Meatball
            /// </summary>
            public static IconUsage CloudMeatball => Get(0xf73b);

            /// <summary>
            /// Cloud with Moon
            /// </summary>
            public static IconUsage CloudMoon => Get(0xf6c3);

            /// <summary>
            /// Cloud with Moon and Rain
            /// </summary>
            public static IconUsage CloudMoonRain => Get(0xf73c);

            /// <summary>
            /// Cloud with Rain
            /// </summary>
            public static IconUsage CloudRain => Get(0xf73d);

            /// <summary>
            /// Cloud with Heavy Showers
            /// </summary>
            public static IconUsage CloudShowersHeavy => Get(0xf740);

            /// <summary>
            /// Cloud with Sun
            /// </summary>
            public static IconUsage CloudSun => Get(0xf6c4);

            /// <summary>
            /// Cloud with Sun and Rain
            /// </summary>
            public static IconUsage CloudSunRain => Get(0xf743);

            /// <summary>
            /// Alternate Cloud Upload
            /// </summary>
            public static IconUsage CloudUploadAlt => Get(0xf382);

            /// <summary>
            /// Cocktail
            /// </summary>
            public static IconUsage Cocktail => Get(0xf561);

            /// <summary>
            /// Code
            /// </summary>
            public static IconUsage Code => Get(0xf121);

            /// <summary>
            /// Code Branch
            /// </summary>
            public static IconUsage CodeBranch => Get(0xf126);

            /// <summary>
            /// Coffee
            /// </summary>
            public static IconUsage Coffee => Get(0xf0f4);

            /// <summary>
            /// cog
            /// </summary>
            public static IconUsage Cog => Get(0xf013);

            /// <summary>
            /// cogs
            /// </summary>
            public static IconUsage Cogs => Get(0xf085);

            /// <summary>
            /// Coins
            /// </summary>
            public static IconUsage Coins => Get(0xf51e);

            /// <summary>
            /// Columns
            /// </summary>
            public static IconUsage Columns => Get(0xf0db);

            /// <summary>
            /// comment
            /// </summary>
            public static IconUsage Comment => Get(0xf075);

            /// <summary>
            /// Alternate Comment
            /// </summary>
            public static IconUsage CommentAlt => Get(0xf27a);

            /// <summary>
            /// Comment Dollar
            /// </summary>
            public static IconUsage CommentDollar => Get(0xf651);

            /// <summary>
            /// Comment Dots
            /// </summary>
            public static IconUsage CommentDots => Get(0xf4ad);

            /// <summary>
            /// Alternate Medical Chat
            /// </summary>
            public static IconUsage CommentMedical => Get(0xf7f5);

            /// <summary>
            /// Comment Slash
            /// </summary>
            public static IconUsage CommentSlash => Get(0xf4b3);

            /// <summary>
            /// comments
            /// </summary>
            public static IconUsage Comments => Get(0xf086);

            /// <summary>
            /// Comments Dollar
            /// </summary>
            public static IconUsage CommentsDollar => Get(0xf653);

            /// <summary>
            /// Compact Disc
            /// </summary>
            public static IconUsage CompactDisc => Get(0xf51f);

            /// <summary>
            /// Compass
            /// </summary>
            public static IconUsage Compass => Get(0xf14e);

            /// <summary>
            /// Compress
            /// </summary>
            public static IconUsage Compress => Get(0xf066);

            /// <summary>
            /// Alternate Compress Arrows
            /// </summary>
            public static IconUsage CompressArrowsAlt => Get(0xf78c);

            /// <summary>
            /// Concierge Bell
            /// </summary>
            public static IconUsage ConciergeBell => Get(0xf562);

            /// <summary>
            /// Cookie
            /// </summary>
            public static IconUsage Cookie => Get(0xf563);

            /// <summary>
            /// Cookie Bite
            /// </summary>
            public static IconUsage CookieBite => Get(0xf564);

            /// <summary>
            /// Copy
            /// </summary>
            public static IconUsage Copy => Get(0xf0c5);

            /// <summary>
            /// Copyright
            /// </summary>
            public static IconUsage Copyright => Get(0xf1f9);

            /// <summary>
            /// Couch
            /// </summary>
            public static IconUsage Couch => Get(0xf4b8);

            /// <summary>
            /// Credit Card
            /// </summary>
            public static IconUsage CreditCard => Get(0xf09d);

            /// <summary>
            /// crop
            /// </summary>
            public static IconUsage Crop => Get(0xf125);

            /// <summary>
            /// Alternate Crop
            /// </summary>
            public static IconUsage CropAlt => Get(0xf565);

            /// <summary>
            /// Cross
            /// </summary>
            public static IconUsage Cross => Get(0xf654);

            /// <summary>
            /// Crosshairs
            /// </summary>
            public static IconUsage Crosshairs => Get(0xf05b);

            /// <summary>
            /// Crow
            /// </summary>
            public static IconUsage Crow => Get(0xf520);

            /// <summary>
            /// Crown
            /// </summary>
            public static IconUsage Crown => Get(0xf521);

            /// <summary>
            /// Crutch
            /// </summary>
            public static IconUsage Crutch => Get(0xf7f7);

            /// <summary>
            /// Cube
            /// </summary>
            public static IconUsage Cube => Get(0xf1b2);

            /// <summary>
            /// Cubes
            /// </summary>
            public static IconUsage Cubes => Get(0xf1b3);

            /// <summary>
            /// Cut
            /// </summary>
            public static IconUsage Cut => Get(0xf0c4);

            /// <summary>
            /// Database
            /// </summary>
            public static IconUsage Database => Get(0xf1c0);

            /// <summary>
            /// Deaf
            /// </summary>
            public static IconUsage Deaf => Get(0xf2a4);

            /// <summary>
            /// Democrat
            /// </summary>
            public static IconUsage Democrat => Get(0xf747);

            /// <summary>
            /// Desktop
            /// </summary>
            public static IconUsage Desktop => Get(0xf108);

            /// <summary>
            /// Dharmachakra
            /// </summary>
            public static IconUsage Dharmachakra => Get(0xf655);

            /// <summary>
            /// Diagnoses
            /// </summary>
            public static IconUsage Diagnoses => Get(0xf470);

            /// <summary>
            /// Dice
            /// </summary>
            public static IconUsage Dice => Get(0xf522);

            /// <summary>
            /// Dice D20
            /// </summary>
            public static IconUsage DiceD20 => Get(0xf6cf);

            /// <summary>
            /// Dice D6
            /// </summary>
            public static IconUsage DiceD6 => Get(0xf6d1);

            /// <summary>
            /// Dice Five
            /// </summary>
            public static IconUsage DiceFive => Get(0xf523);

            /// <summary>
            /// Dice Four
            /// </summary>
            public static IconUsage DiceFour => Get(0xf524);

            /// <summary>
            /// Dice One
            /// </summary>
            public static IconUsage DiceOne => Get(0xf525);

            /// <summary>
            /// Dice Six
            /// </summary>
            public static IconUsage DiceSix => Get(0xf526);

            /// <summary>
            /// Dice Three
            /// </summary>
            public static IconUsage DiceThree => Get(0xf527);

            /// <summary>
            /// Dice Two
            /// </summary>
            public static IconUsage DiceTwo => Get(0xf528);

            /// <summary>
            /// Digital Tachograph
            /// </summary>
            public static IconUsage DigitalTachograph => Get(0xf566);

            /// <summary>
            /// Directions
            /// </summary>
            public static IconUsage Directions => Get(0xf5eb);

            /// <summary>
            /// Divide
            /// </summary>
            public static IconUsage Divide => Get(0xf529);

            /// <summary>
            /// Dizzy Face
            /// </summary>
            public static IconUsage Dizzy => Get(0xf567);

            /// <summary>
            /// DNA
            /// </summary>
            public static IconUsage Dna => Get(0xf471);

            /// <summary>
            /// Dog
            /// </summary>
            public static IconUsage Dog => Get(0xf6d3);

            /// <summary>
            /// Dollar Sign
            /// </summary>
            public static IconUsage DollarSign => Get(0xf155);

            /// <summary>
            /// Dolly
            /// </summary>
            public static IconUsage Dolly => Get(0xf472);

            /// <summary>
            /// Dolly Flatbed
            /// </summary>
            public static IconUsage DollyFlatbed => Get(0xf474);

            /// <summary>
            /// Donate
            /// </summary>
            public static IconUsage Donate => Get(0xf4b9);

            /// <summary>
            /// Door Closed
            /// </summary>
            public static IconUsage DoorClosed => Get(0xf52a);

            /// <summary>
            /// Door Open
            /// </summary>
            public static IconUsage DoorOpen => Get(0xf52b);

            /// <summary>
            /// Dot Circle
            /// </summary>
            public static IconUsage DotCircle => Get(0xf192);

            /// <summary>
            /// Dove
            /// </summary>
            public static IconUsage Dove => Get(0xf4ba);

            /// <summary>
            /// Download
            /// </summary>
            public static IconUsage Download => Get(0xf019);

            /// <summary>
            /// Drafting Compass
            /// </summary>
            public static IconUsage DraftingCompass => Get(0xf568);

            /// <summary>
            /// Dragon
            /// </summary>
            public static IconUsage Dragon => Get(0xf6d5);

            /// <summary>
            /// Draw Polygon
            /// </summary>
            public static IconUsage DrawPolygon => Get(0xf5ee);

            /// <summary>
            /// Drum
            /// </summary>
            public static IconUsage Drum => Get(0xf569);

            /// <summary>
            /// Drum Steelpan
            /// </summary>
            public static IconUsage DrumSteelpan => Get(0xf56a);

            /// <summary>
            /// Drumstick with Bite Taken Out
            /// </summary>
            public static IconUsage DrumstickBite => Get(0xf6d7);

            /// <summary>
            /// Dumbbell
            /// </summary>
            public static IconUsage Dumbbell => Get(0xf44b);

            /// <summary>
            /// Dumpster
            /// </summary>
            public static IconUsage Dumpster => Get(0xf793);

            /// <summary>
            /// Dumpster Fire
            /// </summary>
            public static IconUsage DumpsterFire => Get(0xf794);

            /// <summary>
            /// Dungeon
            /// </summary>
            public static IconUsage Dungeon => Get(0xf6d9);

            /// <summary>
            /// Edit
            /// </summary>
            public static IconUsage Edit => Get(0xf044);

            /// <summary>
            /// Egg
            /// </summary>
            public static IconUsage Egg => Get(0xf7fb);

            /// <summary>
            /// eject
            /// </summary>
            public static IconUsage Eject => Get(0xf052);

            /// <summary>
            /// Horizontal Ellipsis
            /// </summary>
            public static IconUsage EllipsisH => Get(0xf141);

            /// <summary>
            /// Vertical Ellipsis
            /// </summary>
            public static IconUsage EllipsisV => Get(0xf142);

            /// <summary>
            /// Envelope
            /// </summary>
            public static IconUsage Envelope => Get(0xf0e0);

            /// <summary>
            /// Envelope Open
            /// </summary>
            public static IconUsage EnvelopeOpen => Get(0xf2b6);

            /// <summary>
            /// Envelope Open-text
            /// </summary>
            public static IconUsage EnvelopeOpenText => Get(0xf658);

            /// <summary>
            /// Envelope Square
            /// </summary>
            public static IconUsage EnvelopeSquare => Get(0xf199);

            /// <summary>
            /// Equals
            /// </summary>
            public static IconUsage Equals => Get(0xf52c);

            /// <summary>
            /// eraser
            /// </summary>
            public static IconUsage Eraser => Get(0xf12d);

            /// <summary>
            /// Ethernet
            /// </summary>
            public static IconUsage Ethernet => Get(0xf796);

            /// <summary>
            /// Euro Sign
            /// </summary>
            public static IconUsage EuroSign => Get(0xf153);

            /// <summary>
            /// Alternate Exchange
            /// </summary>
            public static IconUsage ExchangeAlt => Get(0xf362);

            /// <summary>
            /// exclamation
            /// </summary>
            public static IconUsage Exclamation => Get(0xf12a);

            /// <summary>
            /// Exclamation Circle
            /// </summary>
            public static IconUsage ExclamationCircle => Get(0xf06a);

            /// <summary>
            /// Exclamation Triangle
            /// </summary>
            public static IconUsage ExclamationTriangle => Get(0xf071);

            /// <summary>
            /// Expand
            /// </summary>
            public static IconUsage Expand => Get(0xf065);

            /// <summary>
            /// Alternate Expand Arrows
            /// </summary>
            public static IconUsage ExpandArrowsAlt => Get(0xf31e);

            /// <summary>
            /// Alternate External Link
            /// </summary>
            public static IconUsage ExternalLinkAlt => Get(0xf35d);

            /// <summary>
            /// Alternate External Link Square
            /// </summary>
            public static IconUsage ExternalLinkSquareAlt => Get(0xf360);

            /// <summary>
            /// Eye
            /// </summary>
            public static IconUsage Eye => Get(0xf06e);

            /// <summary>
            /// Eye Dropper
            /// </summary>
            public static IconUsage EyeDropper => Get(0xf1fb);

            /// <summary>
            /// Eye Slash
            /// </summary>
            public static IconUsage EyeSlash => Get(0xf070);

            /// <summary>
            /// fast-backward
            /// </summary>
            public static IconUsage FastBackward => Get(0xf049);

            /// <summary>
            /// fast-forward
            /// </summary>
            public static IconUsage FastForward => Get(0xf050);

            /// <summary>
            /// Fax
            /// </summary>
            public static IconUsage Fax => Get(0xf1ac);

            /// <summary>
            /// Feather
            /// </summary>
            public static IconUsage Feather => Get(0xf52d);

            /// <summary>
            /// Alternate Feather
            /// </summary>
            public static IconUsage FeatherAlt => Get(0xf56b);

            /// <summary>
            /// Female
            /// </summary>
            public static IconUsage Female => Get(0xf182);

            /// <summary>
            /// fighter-jet
            /// </summary>
            public static IconUsage FighterJet => Get(0xf0fb);

            /// <summary>
            /// File
            /// </summary>
            public static IconUsage File => Get(0xf15b);

            /// <summary>
            /// Alternate File
            /// </summary>
            public static IconUsage FileAlt => Get(0xf15c);

            /// <summary>
            /// Archive File
            /// </summary>
            public static IconUsage FileArchive => Get(0xf1c6);

            /// <summary>
            /// Audio File
            /// </summary>
            public static IconUsage FileAudio => Get(0xf1c7);

            /// <summary>
            /// Code File
            /// </summary>
            public static IconUsage FileCode => Get(0xf1c9);

            /// <summary>
            /// File Contract
            /// </summary>
            public static IconUsage FileContract => Get(0xf56c);

            /// <summary>
            /// File CSV
            /// </summary>
            public static IconUsage FileCsv => Get(0xf6dd);

            /// <summary>
            /// File Download
            /// </summary>
            public static IconUsage FileDownload => Get(0xf56d);

            /// <summary>
            /// Excel File
            /// </summary>
            public static IconUsage FileExcel => Get(0xf1c3);

            /// <summary>
            /// File Export
            /// </summary>
            public static IconUsage FileExport => Get(0xf56e);

            /// <summary>
            /// Image File
            /// </summary>
            public static IconUsage FileImage => Get(0xf1c5);

            /// <summary>
            /// File Import
            /// </summary>
            public static IconUsage FileImport => Get(0xf56f);

            /// <summary>
            /// File Invoice
            /// </summary>
            public static IconUsage FileInvoice => Get(0xf570);

            /// <summary>
            /// File Invoice with US Dollar
            /// </summary>
            public static IconUsage FileInvoiceDollar => Get(0xf571);

            /// <summary>
            /// Medical File
            /// </summary>
            public static IconUsage FileMedical => Get(0xf477);

            /// <summary>
            /// Alternate Medical File
            /// </summary>
            public static IconUsage FileMedicalAlt => Get(0xf478);

            /// <summary>
            /// PDF File
            /// </summary>
            public static IconUsage FilePdf => Get(0xf1c1);

            /// <summary>
            /// Powerpoint File
            /// </summary>
            public static IconUsage FilePowerpoint => Get(0xf1c4);

            /// <summary>
            /// File Prescription
            /// </summary>
            public static IconUsage FilePrescription => Get(0xf572);

            /// <summary>
            /// File Signature
            /// </summary>
            public static IconUsage FileSignature => Get(0xf573);

            /// <summary>
            /// File Upload
            /// </summary>
            public static IconUsage FileUpload => Get(0xf574);

            /// <summary>
            /// Video File
            /// </summary>
            public static IconUsage FileVideo => Get(0xf1c8);

            /// <summary>
            /// Word File
            /// </summary>
            public static IconUsage FileWord => Get(0xf1c2);

            /// <summary>
            /// Fill
            /// </summary>
            public static IconUsage Fill => Get(0xf575);

            /// <summary>
            /// Fill Drip
            /// </summary>
            public static IconUsage FillDrip => Get(0xf576);

            /// <summary>
            /// Film
            /// </summary>
            public static IconUsage Film => Get(0xf008);

            /// <summary>
            /// Filter
            /// </summary>
            public static IconUsage Filter => Get(0xf0b0);

            /// <summary>
            /// Fingerprint
            /// </summary>
            public static IconUsage Fingerprint => Get(0xf577);

            /// <summary>
            /// fire
            /// </summary>
            public static IconUsage Fire => Get(0xf06d);

            /// <summary>
            /// Alternate Fire
            /// </summary>
            public static IconUsage FireAlt => Get(0xf7e4);

            /// <summary>
            /// fire-extinguisher
            /// </summary>
            public static IconUsage FireExtinguisher => Get(0xf134);

            /// <summary>
            /// First Aid
            /// </summary>
            public static IconUsage FirstAid => Get(0xf479);

            /// <summary>
            /// Fish
            /// </summary>
            public static IconUsage Fish => Get(0xf578);

            /// <summary>
            /// Raised Fist
            /// </summary>
            public static IconUsage FistRaised => Get(0xf6de);

            /// <summary>
            /// flag
            /// </summary>
            public static IconUsage Flag => Get(0xf024);

            /// <summary>
            /// flag-checkered
            /// </summary>
            public static IconUsage FlagCheckered => Get(0xf11e);

            /// <summary>
            /// United States of America Flag
            /// </summary>
            public static IconUsage FlagUsa => Get(0xf74d);

            /// <summary>
            /// Flask
            /// </summary>
            public static IconUsage Flask => Get(0xf0c3);

            /// <summary>
            /// Flushed Face
            /// </summary>
            public static IconUsage Flushed => Get(0xf579);

            /// <summary>
            /// Folder
            /// </summary>
            public static IconUsage Folder => Get(0xf07b);

            /// <summary>
            /// Folder Minus
            /// </summary>
            public static IconUsage FolderMinus => Get(0xf65d);

            /// <summary>
            /// Folder Open
            /// </summary>
            public static IconUsage FolderOpen => Get(0xf07c);

            /// <summary>
            /// Folder Plus
            /// </summary>
            public static IconUsage FolderPlus => Get(0xf65e);

            /// <summary>
            /// font
            /// </summary>
            public static IconUsage Font => Get(0xf031);

            /// <summary>
            /// Font Awesome Full Logo
            /// </summary>
            public static IconUsage FontAwesomeLogoFull => Get(0xf4e6);

            /// <summary>
            /// Football Ball
            /// </summary>
            public static IconUsage FootballBall => Get(0xf44e);

            /// <summary>
            /// forward
            /// </summary>
            public static IconUsage Forward => Get(0xf04e);

            /// <summary>
            /// Frog
            /// </summary>
            public static IconUsage Frog => Get(0xf52e);

            /// <summary>
            /// Frowning Face
            /// </summary>
            public static IconUsage Frown => Get(0xf119);

            /// <summary>
            /// Frowning Face With Open Mouth
            /// </summary>
            public static IconUsage FrownOpen => Get(0xf57a);

            /// <summary>
            /// Funnel Dollar
            /// </summary>
            public static IconUsage FunnelDollar => Get(0xf662);

            /// <summary>
            /// Futbol
            /// </summary>
            public static IconUsage Futbol => Get(0xf1e3);

            /// <summary>
            /// Gamepad
            /// </summary>
            public static IconUsage Gamepad => Get(0xf11b);

            /// <summary>
            /// Gas Pump
            /// </summary>
            public static IconUsage GasPump => Get(0xf52f);

            /// <summary>
            /// Gavel
            /// </summary>
            public static IconUsage Gavel => Get(0xf0e3);

            /// <summary>
            /// Gem
            /// </summary>
            public static IconUsage Gem => Get(0xf3a5);

            /// <summary>
            /// Genderless
            /// </summary>
            public static IconUsage Genderless => Get(0xf22d);

            /// <summary>
            /// Ghost
            /// </summary>
            public static IconUsage Ghost => Get(0xf6e2);

            /// <summary>
            /// gift
            /// </summary>
            public static IconUsage Gift => Get(0xf06b);

            /// <summary>
            /// Gifts
            /// </summary>
            public static IconUsage Gifts => Get(0xf79c);

            /// <summary>
            /// Glass Cheers
            /// </summary>
            public static IconUsage GlassCheers => Get(0xf79f);

            /// <summary>
            /// Martini Glass
            /// </summary>
            public static IconUsage GlassMartini => Get(0xf000);

            /// <summary>
            /// Alternate Glass Martini
            /// </summary>
            public static IconUsage GlassMartiniAlt => Get(0xf57b);

            /// <summary>
            /// Glass Whiskey
            /// </summary>
            public static IconUsage GlassWhiskey => Get(0xf7a0);

            /// <summary>
            /// Glasses
            /// </summary>
            public static IconUsage Glasses => Get(0xf530);

            /// <summary>
            /// Globe
            /// </summary>
            public static IconUsage Globe => Get(0xf0ac);

            /// <summary>
            /// Globe with Africa shown
            /// </summary>
            public static IconUsage GlobeAfrica => Get(0xf57c);

            /// <summary>
            /// Globe with Americas shown
            /// </summary>
            public static IconUsage GlobeAmericas => Get(0xf57d);

            /// <summary>
            /// Globe with Asia shown
            /// </summary>
            public static IconUsage GlobeAsia => Get(0xf57e);

            /// <summary>
            /// Globe with Europe shown
            /// </summary>
            public static IconUsage GlobeEurope => Get(0xf7a2);

            /// <summary>
            /// Golf Ball
            /// </summary>
            public static IconUsage GolfBall => Get(0xf450);

            /// <summary>
            /// Gopuram
            /// </summary>
            public static IconUsage Gopuram => Get(0xf664);

            /// <summary>
            /// Graduation Cap
            /// </summary>
            public static IconUsage GraduationCap => Get(0xf19d);

            /// <summary>
            /// Greater Than
            /// </summary>
            public static IconUsage GreaterThan => Get(0xf531);

            /// <summary>
            /// Greater Than Equal To
            /// </summary>
            public static IconUsage GreaterThanEqual => Get(0xf532);

            /// <summary>
            /// Grimacing Face
            /// </summary>
            public static IconUsage Grimace => Get(0xf57f);

            /// <summary>
            /// Grinning Face
            /// </summary>
            public static IconUsage Grin => Get(0xf580);

            /// <summary>
            /// Alternate Grinning Face
            /// </summary>
            public static IconUsage GrinAlt => Get(0xf581);

            /// <summary>
            /// Grinning Face With Smiling Eyes
            /// </summary>
            public static IconUsage GrinBeam => Get(0xf582);

            /// <summary>
            /// Grinning Face With Sweat
            /// </summary>
            public static IconUsage GrinBeamSweat => Get(0xf583);

            /// <summary>
            /// Smiling Face With Heart-Eyes
            /// </summary>
            public static IconUsage GrinHearts => Get(0xf584);

            /// <summary>
            /// Grinning Squinting Face
            /// </summary>
            public static IconUsage GrinSquint => Get(0xf585);

            /// <summary>
            /// Rolling on the Floor Laughing
            /// </summary>
            public static IconUsage GrinSquintTears => Get(0xf586);

            /// <summary>
            /// Star-Struck
            /// </summary>
            public static IconUsage GrinStars => Get(0xf587);

            /// <summary>
            /// Face With Tears of Joy
            /// </summary>
            public static IconUsage GrinTears => Get(0xf588);

            /// <summary>
            /// Face With Tongue
            /// </summary>
            public static IconUsage GrinTongue => Get(0xf589);

            /// <summary>
            /// Squinting Face With Tongue
            /// </summary>
            public static IconUsage GrinTongueSquint => Get(0xf58a);

            /// <summary>
            /// Winking Face With Tongue
            /// </summary>
            public static IconUsage GrinTongueWink => Get(0xf58b);

            /// <summary>
            /// Grinning Winking Face
            /// </summary>
            public static IconUsage GrinWink => Get(0xf58c);

            /// <summary>
            /// Grip Horizontal
            /// </summary>
            public static IconUsage GripHorizontal => Get(0xf58d);

            /// <summary>
            /// Grip Lines
            /// </summary>
            public static IconUsage GripLines => Get(0xf7a4);

            /// <summary>
            /// Grip Lines Vertical
            /// </summary>
            public static IconUsage GripLinesVertical => Get(0xf7a5);

            /// <summary>
            /// Grip Vertical
            /// </summary>
            public static IconUsage GripVertical => Get(0xf58e);

            /// <summary>
            /// Guitar
            /// </summary>
            public static IconUsage Guitar => Get(0xf7a6);

            /// <summary>
            /// H Square
            /// </summary>
            public static IconUsage HSquare => Get(0xf0fd);

            /// <summary>
            /// Hamburger
            /// </summary>
            public static IconUsage Hamburger => Get(0xf805);

            /// <summary>
            /// Hammer
            /// </summary>
            public static IconUsage Hammer => Get(0xf6e3);

            /// <summary>
            /// Hamsa
            /// </summary>
            public static IconUsage Hamsa => Get(0xf665);

            /// <summary>
            /// Hand Holding
            /// </summary>
            public static IconUsage HandHolding => Get(0xf4bd);

            /// <summary>
            /// Hand Holding Heart
            /// </summary>
            public static IconUsage HandHoldingHeart => Get(0xf4be);

            /// <summary>
            /// Hand Holding US Dollar
            /// </summary>
            public static IconUsage HandHoldingUsd => Get(0xf4c0);

            /// <summary>
            /// Lizard (Hand)
            /// </summary>
            public static IconUsage HandLizard => Get(0xf258);

            /// <summary>
            /// Hand with Middle Finger Raised
            /// </summary>
            public static IconUsage HandMiddleFinger => Get(0xf806);

            /// <summary>
            /// Paper (Hand)
            /// </summary>
            public static IconUsage HandPaper => Get(0xf256);

            /// <summary>
            /// Peace (Hand)
            /// </summary>
            public static IconUsage HandPeace => Get(0xf25b);

            /// <summary>
            /// Hand Pointing Down
            /// </summary>
            public static IconUsage HandPointDown => Get(0xf0a7);

            /// <summary>
            /// Hand Pointing Left
            /// </summary>
            public static IconUsage HandPointLeft => Get(0xf0a5);

            /// <summary>
            /// Hand Pointing Right
            /// </summary>
            public static IconUsage HandPointRight => Get(0xf0a4);

            /// <summary>
            /// Hand Pointing Up
            /// </summary>
            public static IconUsage HandPointUp => Get(0xf0a6);

            /// <summary>
            /// Pointer (Hand)
            /// </summary>
            public static IconUsage HandPointer => Get(0xf25a);

            /// <summary>
            /// Rock (Hand)
            /// </summary>
            public static IconUsage HandRock => Get(0xf255);

            /// <summary>
            /// Scissors (Hand)
            /// </summary>
            public static IconUsage HandScissors => Get(0xf257);

            /// <summary>
            /// Spock (Hand)
            /// </summary>
            public static IconUsage HandSpock => Get(0xf259);

            /// <summary>
            /// Hands
            /// </summary>
            public static IconUsage Hands => Get(0xf4c2);

            /// <summary>
            /// Helping Hands
            /// </summary>
            public static IconUsage HandsHelping => Get(0xf4c4);

            /// <summary>
            /// Handshake
            /// </summary>
            public static IconUsage Handshake => Get(0xf2b5);

            /// <summary>
            /// Hanukiah
            /// </summary>
            public static IconUsage Hanukiah => Get(0xf6e6);

            /// <summary>
            /// Hard Hat
            /// </summary>
            public static IconUsage HardHat => Get(0xf807);

            /// <summary>
            /// Hashtag
            /// </summary>
            public static IconUsage Hashtag => Get(0xf292);

            /// <summary>
            /// Wizard's Hat
            /// </summary>
            public static IconUsage HatWizard => Get(0xf6e8);

            /// <summary>
            /// Haykal
            /// </summary>
            public static IconUsage Haykal => Get(0xf666);

            /// <summary>
            /// HDD
            /// </summary>
            public static IconUsage Hdd => Get(0xf0a0);

            /// <summary>
            /// heading
            /// </summary>
            public static IconUsage Heading => Get(0xf1dc);

            /// <summary>
            /// headphones
            /// </summary>
            public static IconUsage Headphones => Get(0xf025);

            /// <summary>
            /// Alternate Headphones
            /// </summary>
            public static IconUsage HeadphonesAlt => Get(0xf58f);

            /// <summary>
            /// Headset
            /// </summary>
            public static IconUsage Headset => Get(0xf590);

            /// <summary>
            /// Heart
            /// </summary>
            public static IconUsage Heart => Get(0xf004);

            /// <summary>
            /// Heart Broken
            /// </summary>
            public static IconUsage HeartBroken => Get(0xf7a9);

            /// <summary>
            /// Heartbeat
            /// </summary>
            public static IconUsage Heartbeat => Get(0xf21e);

            /// <summary>
            /// Helicopter
            /// </summary>
            public static IconUsage Helicopter => Get(0xf533);

            /// <summary>
            /// Highlighter
            /// </summary>
            public static IconUsage Highlighter => Get(0xf591);

            /// <summary>
            /// Hiking
            /// </summary>
            public static IconUsage Hiking => Get(0xf6ec);

            /// <summary>
            /// Hippo
            /// </summary>
            public static IconUsage Hippo => Get(0xf6ed);

            /// <summary>
            /// History
            /// </summary>
            public static IconUsage History => Get(0xf1da);

            /// <summary>
            /// Hockey Puck
            /// </summary>
            public static IconUsage HockeyPuck => Get(0xf453);

            /// <summary>
            /// Holly Berry
            /// </summary>
            public static IconUsage HollyBerry => Get(0xf7aa);

            /// <summary>
            /// home
            /// </summary>
            public static IconUsage Home => Get(0xf015);

            /// <summary>
            /// Horse
            /// </summary>
            public static IconUsage Horse => Get(0xf6f0);

            /// <summary>
            /// Horse Head
            /// </summary>
            public static IconUsage HorseHead => Get(0xf7ab);

            /// <summary>
            /// hospital
            /// </summary>
            public static IconUsage Hospital => Get(0xf0f8);

            /// <summary>
            /// Alternate Hospital
            /// </summary>
            public static IconUsage HospitalAlt => Get(0xf47d);

            /// <summary>
            /// Hospital Symbol
            /// </summary>
            public static IconUsage HospitalSymbol => Get(0xf47e);

            /// <summary>
            /// Hot Tub
            /// </summary>
            public static IconUsage HotTub => Get(0xf593);

            /// <summary>
            /// Hot Dog
            /// </summary>
            public static IconUsage Hotdog => Get(0xf80f);

            /// <summary>
            /// Hotel
            /// </summary>
            public static IconUsage Hotel => Get(0xf594);

            /// <summary>
            /// Hourglass
            /// </summary>
            public static IconUsage Hourglass => Get(0xf254);

            /// <summary>
            /// Hourglass End
            /// </summary>
            public static IconUsage HourglassEnd => Get(0xf253);

            /// <summary>
            /// Hourglass Half
            /// </summary>
            public static IconUsage HourglassHalf => Get(0xf252);

            /// <summary>
            /// Hourglass Start
            /// </summary>
            public static IconUsage HourglassStart => Get(0xf251);

            /// <summary>
            /// Damaged House
            /// </summary>
            public static IconUsage HouseDamage => Get(0xf6f1);

            /// <summary>
            /// Hryvnia
            /// </summary>
            public static IconUsage Hryvnia => Get(0xf6f2);

            /// <summary>
            /// I Beam Cursor
            /// </summary>
            public static IconUsage ICursor => Get(0xf246);

            /// <summary>
            /// Ice Cream
            /// </summary>
            public static IconUsage IceCream => Get(0xf810);

            /// <summary>
            /// Icicles
            /// </summary>
            public static IconUsage Icicles => Get(0xf7ad);

            /// <summary>
            /// Identification Badge
            /// </summary>
            public static IconUsage IdBadge => Get(0xf2c1);

            /// <summary>
            /// Identification Card
            /// </summary>
            public static IconUsage IdCard => Get(0xf2c2);

            /// <summary>
            /// Alternate Identification Card
            /// </summary>
            public static IconUsage IdCardAlt => Get(0xf47f);

            /// <summary>
            /// Igloo
            /// </summary>
            public static IconUsage Igloo => Get(0xf7ae);

            /// <summary>
            /// Image
            /// </summary>
            public static IconUsage Image => Get(0xf03e);

            /// <summary>
            /// Images
            /// </summary>
            public static IconUsage Images => Get(0xf302);

            /// <summary>
            /// inbox
            /// </summary>
            public static IconUsage Inbox => Get(0xf01c);

            /// <summary>
            /// Indent
            /// </summary>
            public static IconUsage Indent => Get(0xf03c);

            /// <summary>
            /// Industry
            /// </summary>
            public static IconUsage Industry => Get(0xf275);

            /// <summary>
            /// Infinity
            /// </summary>
            public static IconUsage Infinity => Get(0xf534);

            /// <summary>
            /// Info
            /// </summary>
            public static IconUsage Info => Get(0xf129);

            /// <summary>
            /// Info Circle
            /// </summary>
            public static IconUsage InfoCircle => Get(0xf05a);

            /// <summary>
            /// italic
            /// </summary>
            public static IconUsage Italic => Get(0xf033);

            /// <summary>
            /// Jedi
            /// </summary>
            public static IconUsage Jedi => Get(0xf669);

            /// <summary>
            /// Joint
            /// </summary>
            public static IconUsage Joint => Get(0xf595);

            /// <summary>
            /// Journal of the Whills
            /// </summary>
            public static IconUsage JournalWhills => Get(0xf66a);

            /// <summary>
            /// Kaaba
            /// </summary>
            public static IconUsage Kaaba => Get(0xf66b);

            /// <summary>
            /// key
            /// </summary>
            public static IconUsage Key => Get(0xf084);

            /// <summary>
            /// Keyboard
            /// </summary>
            public static IconUsage Keyboard => Get(0xf11c);

            /// <summary>
            /// Khanda
            /// </summary>
            public static IconUsage Khanda => Get(0xf66d);

            /// <summary>
            /// Kissing Face
            /// </summary>
            public static IconUsage Kiss => Get(0xf596);

            /// <summary>
            /// Kissing Face With Smiling Eyes
            /// </summary>
            public static IconUsage KissBeam => Get(0xf597);

            /// <summary>
            /// Face Blowing a Kiss
            /// </summary>
            public static IconUsage KissWinkHeart => Get(0xf598);

            /// <summary>
            /// Kiwi Bird
            /// </summary>
            public static IconUsage KiwiBird => Get(0xf535);

            /// <summary>
            /// Landmark
            /// </summary>
            public static IconUsage Landmark => Get(0xf66f);

            /// <summary>
            /// Language
            /// </summary>
            public static IconUsage Language => Get(0xf1ab);

            /// <summary>
            /// Laptop
            /// </summary>
            public static IconUsage Laptop => Get(0xf109);

            /// <summary>
            /// Laptop Code
            /// </summary>
            public static IconUsage LaptopCode => Get(0xf5fc);

            /// <summary>
            /// Laptop Medical
            /// </summary>
            public static IconUsage LaptopMedical => Get(0xf812);

            /// <summary>
            /// Grinning Face With Big Eyes
            /// </summary>
            public static IconUsage Laugh => Get(0xf599);

            /// <summary>
            /// Laugh Face with Beaming Eyes
            /// </summary>
            public static IconUsage LaughBeam => Get(0xf59a);

            /// <summary>
            /// Laughing Squinting Face
            /// </summary>
            public static IconUsage LaughSquint => Get(0xf59b);

            /// <summary>
            /// Laughing Winking Face
            /// </summary>
            public static IconUsage LaughWink => Get(0xf59c);

            /// <summary>
            /// Layer Group
            /// </summary>
            public static IconUsage LayerGroup => Get(0xf5fd);

            /// <summary>
            /// leaf
            /// </summary>
            public static IconUsage Leaf => Get(0xf06c);

            /// <summary>
            /// Lemon
            /// </summary>
            public static IconUsage Lemon => Get(0xf094);

            /// <summary>
            /// Less Than
            /// </summary>
            public static IconUsage LessThan => Get(0xf536);

            /// <summary>
            /// Less Than Equal To
            /// </summary>
            public static IconUsage LessThanEqual => Get(0xf537);

            /// <summary>
            /// Alternate Level Down
            /// </summary>
            public static IconUsage LevelDownAlt => Get(0xf3be);

            /// <summary>
            /// Alternate Level Up
            /// </summary>
            public static IconUsage LevelUpAlt => Get(0xf3bf);

            /// <summary>
            /// Life Ring
            /// </summary>
            public static IconUsage LifeRing => Get(0xf1cd);

            /// <summary>
            /// Lightbulb
            /// </summary>
            public static IconUsage Lightbulb => Get(0xf0eb);

            /// <summary>
            /// Link
            /// </summary>
            public static IconUsage Link => Get(0xf0c1);

            /// <summary>
            /// Turkish Lira Sign
            /// </summary>
            public static IconUsage LiraSign => Get(0xf195);

            /// <summary>
            /// List
            /// </summary>
            public static IconUsage List => Get(0xf03a);

            /// <summary>
            /// Alternate List
            /// </summary>
            public static IconUsage ListAlt => Get(0xf022);

            /// <summary>
            /// list-ol
            /// </summary>
            public static IconUsage ListOl => Get(0xf0cb);

            /// <summary>
            /// list-ul
            /// </summary>
            public static IconUsage ListUl => Get(0xf0ca);

            /// <summary>
            /// location-arrow
            /// </summary>
            public static IconUsage LocationArrow => Get(0xf124);

            /// <summary>
            /// lock
            /// </summary>
            public static IconUsage Lock => Get(0xf023);

            /// <summary>
            /// Lock Open
            /// </summary>
            public static IconUsage LockOpen => Get(0xf3c1);

            /// <summary>
            /// Alternate Long Arrow Down
            /// </summary>
            public static IconUsage LongArrowAltDown => Get(0xf309);

            /// <summary>
            /// Alternate Long Arrow Left
            /// </summary>
            public static IconUsage LongArrowAltLeft => Get(0xf30a);

            /// <summary>
            /// Alternate Long Arrow Right
            /// </summary>
            public static IconUsage LongArrowAltRight => Get(0xf30b);

            /// <summary>
            /// Alternate Long Arrow Up
            /// </summary>
            public static IconUsage LongArrowAltUp => Get(0xf30c);

            /// <summary>
            /// Low Vision
            /// </summary>
            public static IconUsage LowVision => Get(0xf2a8);

            /// <summary>
            /// Luggage Cart
            /// </summary>
            public static IconUsage LuggageCart => Get(0xf59d);

            /// <summary>
            /// magic
            /// </summary>
            public static IconUsage Magic => Get(0xf0d0);

            /// <summary>
            /// magnet
            /// </summary>
            public static IconUsage Magnet => Get(0xf076);

            /// <summary>
            /// Mail Bulk
            /// </summary>
            public static IconUsage MailBulk => Get(0xf674);

            /// <summary>
            /// Male
            /// </summary>
            public static IconUsage Male => Get(0xf183);

            /// <summary>
            /// Map
            /// </summary>
            public static IconUsage Map => Get(0xf279);

            /// <summary>
            /// Map Marked
            /// </summary>
            public static IconUsage MapMarked => Get(0xf59f);

            /// <summary>
            /// Alternate Map Marked
            /// </summary>
            public static IconUsage MapMarkedAlt => Get(0xf5a0);

            /// <summary>
            /// map-marker
            /// </summary>
            public static IconUsage MapMarker => Get(0xf041);

            /// <summary>
            /// Alternate Map Marker
            /// </summary>
            public static IconUsage MapMarkerAlt => Get(0xf3c5);

            /// <summary>
            /// Map Pin
            /// </summary>
            public static IconUsage MapPin => Get(0xf276);

            /// <summary>
            /// Map Signs
            /// </summary>
            public static IconUsage MapSigns => Get(0xf277);

            /// <summary>
            /// Marker
            /// </summary>
            public static IconUsage Marker => Get(0xf5a1);

            /// <summary>
            /// Mars
            /// </summary>
            public static IconUsage Mars => Get(0xf222);

            /// <summary>
            /// Mars Double
            /// </summary>
            public static IconUsage MarsDouble => Get(0xf227);

            /// <summary>
            /// Mars Stroke
            /// </summary>
            public static IconUsage MarsStroke => Get(0xf229);

            /// <summary>
            /// Mars Stroke Horizontal
            /// </summary>
            public static IconUsage MarsStrokeH => Get(0xf22b);

            /// <summary>
            /// Mars Stroke Vertical
            /// </summary>
            public static IconUsage MarsStrokeV => Get(0xf22a);

            /// <summary>
            /// Mask
            /// </summary>
            public static IconUsage Mask => Get(0xf6fa);

            /// <summary>
            /// Medal
            /// </summary>
            public static IconUsage Medal => Get(0xf5a2);

            /// <summary>
            /// medkit
            /// </summary>
            public static IconUsage Medkit => Get(0xf0fa);

            /// <summary>
            /// Neutral Face
            /// </summary>
            public static IconUsage Meh => Get(0xf11a);

            /// <summary>
            /// Face Without Mouth
            /// </summary>
            public static IconUsage MehBlank => Get(0xf5a4);

            /// <summary>
            /// Face With Rolling Eyes
            /// </summary>
            public static IconUsage MehRollingEyes => Get(0xf5a5);

            /// <summary>
            /// Memory
            /// </summary>
            public static IconUsage Memory => Get(0xf538);

            /// <summary>
            /// Menorah
            /// </summary>
            public static IconUsage Menorah => Get(0xf676);

            /// <summary>
            /// Mercury
            /// </summary>
            public static IconUsage Mercury => Get(0xf223);

            /// <summary>
            /// Meteor
            /// </summary>
            public static IconUsage Meteor => Get(0xf753);

            /// <summary>
            /// Microchip
            /// </summary>
            public static IconUsage Microchip => Get(0xf2db);

            /// <summary>
            /// microphone
            /// </summary>
            public static IconUsage Microphone => Get(0xf130);

            /// <summary>
            /// Alternate Microphone
            /// </summary>
            public static IconUsage MicrophoneAlt => Get(0xf3c9);

            /// <summary>
            /// Alternate Microphone Slash
            /// </summary>
            public static IconUsage MicrophoneAltSlash => Get(0xf539);

            /// <summary>
            /// Microphone Slash
            /// </summary>
            public static IconUsage MicrophoneSlash => Get(0xf131);

            /// <summary>
            /// Microscope
            /// </summary>
            public static IconUsage Microscope => Get(0xf610);

            /// <summary>
            /// minus
            /// </summary>
            public static IconUsage Minus => Get(0xf068);

            /// <summary>
            /// Minus Circle
            /// </summary>
            public static IconUsage MinusCircle => Get(0xf056);

            /// <summary>
            /// Minus Square
            /// </summary>
            public static IconUsage MinusSquare => Get(0xf146);

            /// <summary>
            /// Mitten
            /// </summary>
            public static IconUsage Mitten => Get(0xf7b5);

            /// <summary>
            /// Mobile Phone
            /// </summary>
            public static IconUsage Mobile => Get(0xf10b);

            /// <summary>
            /// Alternate Mobile
            /// </summary>
            public static IconUsage MobileAlt => Get(0xf3cd);

            /// <summary>
            /// Money Bill
            /// </summary>
            public static IconUsage MoneyBill => Get(0xf0d6);

            /// <summary>
            /// Alternate Money Bill
            /// </summary>
            public static IconUsage MoneyBillAlt => Get(0xf3d1);

            /// <summary>
            /// Wavy Money Bill
            /// </summary>
            public static IconUsage MoneyBillWave => Get(0xf53a);

            /// <summary>
            /// Alternate Wavy Money Bill
            /// </summary>
            public static IconUsage MoneyBillWaveAlt => Get(0xf53b);

            /// <summary>
            /// Money Check
            /// </summary>
            public static IconUsage MoneyCheck => Get(0xf53c);

            /// <summary>
            /// Alternate Money Check
            /// </summary>
            public static IconUsage MoneyCheckAlt => Get(0xf53d);

            /// <summary>
            /// Monument
            /// </summary>
            public static IconUsage Monument => Get(0xf5a6);

            /// <summary>
            /// Moon
            /// </summary>
            public static IconUsage Moon => Get(0xf186);

            /// <summary>
            /// Mortar Pestle
            /// </summary>
            public static IconUsage MortarPestle => Get(0xf5a7);

            /// <summary>
            /// Mosque
            /// </summary>
            public static IconUsage Mosque => Get(0xf678);

            /// <summary>
            /// Motorcycle
            /// </summary>
            public static IconUsage Motorcycle => Get(0xf21c);

            /// <summary>
            /// Mountain
            /// </summary>
            public static IconUsage Mountain => Get(0xf6fc);

            /// <summary>
            /// Mouse Pointer
            /// </summary>
            public static IconUsage MousePointer => Get(0xf245);

            /// <summary>
            /// Mug Hot
            /// </summary>
            public static IconUsage MugHot => Get(0xf7b6);

            /// <summary>
            /// Music
            /// </summary>
            public static IconUsage Music => Get(0xf001);

            /// <summary>
            /// Wired Network
            /// </summary>
            public static IconUsage NetworkWired => Get(0xf6ff);

            /// <summary>
            /// Neuter
            /// </summary>
            public static IconUsage Neuter => Get(0xf22c);

            /// <summary>
            /// Newspaper
            /// </summary>
            public static IconUsage Newspaper => Get(0xf1ea);

            /// <summary>
            /// Not Equal
            /// </summary>
            public static IconUsage NotEqual => Get(0xf53e);

            /// <summary>
            /// Medical Notes
            /// </summary>
            public static IconUsage NotesMedical => Get(0xf481);

            /// <summary>
            /// Object Group
            /// </summary>
            public static IconUsage ObjectGroup => Get(0xf247);

            /// <summary>
            /// Object Ungroup
            /// </summary>
            public static IconUsage ObjectUngroup => Get(0xf248);

            /// <summary>
            /// Oil Can
            /// </summary>
            public static IconUsage OilCan => Get(0xf613);

            /// <summary>
            /// Om
            /// </summary>
            public static IconUsage Om => Get(0xf679);

            /// <summary>
            /// Otter
            /// </summary>
            public static IconUsage Otter => Get(0xf700);

            /// <summary>
            /// Outdent
            /// </summary>
            public static IconUsage Outdent => Get(0xf03b);

            /// <summary>
            /// Pager
            /// </summary>
            public static IconUsage Pager => Get(0xf815);

            /// <summary>
            /// Paint Brush
            /// </summary>
            public static IconUsage PaintBrush => Get(0xf1fc);

            /// <summary>
            /// Paint Roller
            /// </summary>
            public static IconUsage PaintRoller => Get(0xf5aa);

            /// <summary>
            /// Palette
            /// </summary>
            public static IconUsage Palette => Get(0xf53f);

            /// <summary>
            /// Pallet
            /// </summary>
            public static IconUsage Pallet => Get(0xf482);

            /// <summary>
            /// Paper Plane
            /// </summary>
            public static IconUsage PaperPlane => Get(0xf1d8);

            /// <summary>
            /// Paperclip
            /// </summary>
            public static IconUsage Paperclip => Get(0xf0c6);

            /// <summary>
            /// Parachute Box
            /// </summary>
            public static IconUsage ParachuteBox => Get(0xf4cd);

            /// <summary>
            /// paragraph
            /// </summary>
            public static IconUsage Paragraph => Get(0xf1dd);

            /// <summary>
            /// Parking
            /// </summary>
            public static IconUsage Parking => Get(0xf540);

            /// <summary>
            /// Passport
            /// </summary>
            public static IconUsage Passport => Get(0xf5ab);

            /// <summary>
            /// Pastafarianism
            /// </summary>
            public static IconUsage Pastafarianism => Get(0xf67b);

            /// <summary>
            /// Paste
            /// </summary>
            public static IconUsage Paste => Get(0xf0ea);

            /// <summary>
            /// pause
            /// </summary>
            public static IconUsage Pause => Get(0xf04c);

            /// <summary>
            /// Pause Circle
            /// </summary>
            public static IconUsage PauseCircle => Get(0xf28b);

            /// <summary>
            /// Paw
            /// </summary>
            public static IconUsage Paw => Get(0xf1b0);

            /// <summary>
            /// Peace
            /// </summary>
            public static IconUsage Peace => Get(0xf67c);

            /// <summary>
            /// Pen
            /// </summary>
            public static IconUsage Pen => Get(0xf304);

            /// <summary>
            /// Alternate Pen
            /// </summary>
            public static IconUsage PenAlt => Get(0xf305);

            /// <summary>
            /// Pen Fancy
            /// </summary>
            public static IconUsage PenFancy => Get(0xf5ac);

            /// <summary>
            /// Pen Nib
            /// </summary>
            public static IconUsage PenNib => Get(0xf5ad);

            /// <summary>
            /// Pen Square
            /// </summary>
            public static IconUsage PenSquare => Get(0xf14b);

            /// <summary>
            /// Alternate Pencil
            /// </summary>
            public static IconUsage PencilAlt => Get(0xf303);

            /// <summary>
            /// Pencil Ruler
            /// </summary>
            public static IconUsage PencilRuler => Get(0xf5ae);

            /// <summary>
            /// People Carry
            /// </summary>
            public static IconUsage PeopleCarry => Get(0xf4ce);

            /// <summary>
            /// Hot Pepper
            /// </summary>
            public static IconUsage PepperHot => Get(0xf816);

            /// <summary>
            /// Percent
            /// </summary>
            public static IconUsage Percent => Get(0xf295);

            /// <summary>
            /// Percentage
            /// </summary>
            public static IconUsage Percentage => Get(0xf541);

            /// <summary>
            /// Person Entering Booth
            /// </summary>
            public static IconUsage PersonBooth => Get(0xf756);

            /// <summary>
            /// Phone
            /// </summary>
            public static IconUsage Phone => Get(0xf095);

            /// <summary>
            /// Phone Slash
            /// </summary>
            public static IconUsage PhoneSlash => Get(0xf3dd);

            /// <summary>
            /// Phone Square
            /// </summary>
            public static IconUsage PhoneSquare => Get(0xf098);

            /// <summary>
            /// Phone Volume
            /// </summary>
            public static IconUsage PhoneVolume => Get(0xf2a0);

            /// <summary>
            /// Piggy Bank
            /// </summary>
            public static IconUsage PiggyBank => Get(0xf4d3);

            /// <summary>
            /// Pills
            /// </summary>
            public static IconUsage Pills => Get(0xf484);

            /// <summary>
            /// Pizza Slice
            /// </summary>
            public static IconUsage PizzaSlice => Get(0xf818);

            /// <summary>
            /// Place of Worship
            /// </summary>
            public static IconUsage PlaceOfWorship => Get(0xf67f);

            /// <summary>
            /// plane
            /// </summary>
            public static IconUsage Plane => Get(0xf072);

            /// <summary>
            /// Plane Arrival
            /// </summary>
            public static IconUsage PlaneArrival => Get(0xf5af);

            /// <summary>
            /// Plane Departure
            /// </summary>
            public static IconUsage PlaneDeparture => Get(0xf5b0);

            /// <summary>
            /// play
            /// </summary>
            public static IconUsage Play => Get(0xf04b);

            /// <summary>
            /// Play Circle
            /// </summary>
            public static IconUsage PlayCircle => Get(0xf144);

            /// <summary>
            /// Plug
            /// </summary>
            public static IconUsage Plug => Get(0xf1e6);

            /// <summary>
            /// plus
            /// </summary>
            public static IconUsage Plus => Get(0xf067);

            /// <summary>
            /// Plus Circle
            /// </summary>
            public static IconUsage PlusCircle => Get(0xf055);

            /// <summary>
            /// Plus Square
            /// </summary>
            public static IconUsage PlusSquare => Get(0xf0fe);

            /// <summary>
            /// Podcast
            /// </summary>
            public static IconUsage Podcast => Get(0xf2ce);

            /// <summary>
            /// Poll
            /// </summary>
            public static IconUsage Poll => Get(0xf681);

            /// <summary>
            /// Poll H
            /// </summary>
            public static IconUsage PollH => Get(0xf682);

            /// <summary>
            /// Poo
            /// </summary>
            public static IconUsage Poo => Get(0xf2fe);

            /// <summary>
            /// Poo Storm
            /// </summary>
            public static IconUsage PooStorm => Get(0xf75a);

            /// <summary>
            /// Poop
            /// </summary>
            public static IconUsage Poop => Get(0xf619);

            /// <summary>
            /// Portrait
            /// </summary>
            public static IconUsage Portrait => Get(0xf3e0);

            /// <summary>
            /// Pound Sign
            /// </summary>
            public static IconUsage PoundSign => Get(0xf154);

            /// <summary>
            /// Power Off
            /// </summary>
            public static IconUsage PowerOff => Get(0xf011);

            /// <summary>
            /// Pray
            /// </summary>
            public static IconUsage Pray => Get(0xf683);

            /// <summary>
            /// Praying Hands
            /// </summary>
            public static IconUsage PrayingHands => Get(0xf684);

            /// <summary>
            /// Prescription
            /// </summary>
            public static IconUsage Prescription => Get(0xf5b1);

            /// <summary>
            /// Prescription Bottle
            /// </summary>
            public static IconUsage PrescriptionBottle => Get(0xf485);

            /// <summary>
            /// Alternate Prescription Bottle
            /// </summary>
            public static IconUsage PrescriptionBottleAlt => Get(0xf486);

            /// <summary>
            /// print
            /// </summary>
            public static IconUsage Print => Get(0xf02f);

            /// <summary>
            /// Procedures
            /// </summary>
            public static IconUsage Procedures => Get(0xf487);

            /// <summary>
            /// Project Diagram
            /// </summary>
            public static IconUsage ProjectDiagram => Get(0xf542);

            /// <summary>
            /// Puzzle Piece
            /// </summary>
            public static IconUsage PuzzlePiece => Get(0xf12e);

            /// <summary>
            /// qrcode
            /// </summary>
            public static IconUsage Qrcode => Get(0xf029);

            /// <summary>
            /// Question
            /// </summary>
            public static IconUsage Question => Get(0xf128);

            /// <summary>
            /// Question Circle
            /// </summary>
            public static IconUsage QuestionCircle => Get(0xf059);

            /// <summary>
            /// Quidditch
            /// </summary>
            public static IconUsage Quidditch => Get(0xf458);

            /// <summary>
            /// quote-left
            /// </summary>
            public static IconUsage QuoteLeft => Get(0xf10d);

            /// <summary>
            /// quote-right
            /// </summary>
            public static IconUsage QuoteRight => Get(0xf10e);

            /// <summary>
            /// Quran
            /// </summary>
            public static IconUsage Quran => Get(0xf687);

            /// <summary>
            /// Radiation
            /// </summary>
            public static IconUsage Radiation => Get(0xf7b9);

            /// <summary>
            /// Alternate Radiation
            /// </summary>
            public static IconUsage RadiationAlt => Get(0xf7ba);

            /// <summary>
            /// Rainbow
            /// </summary>
            public static IconUsage Rainbow => Get(0xf75b);

            /// <summary>
            /// random
            /// </summary>
            public static IconUsage Random => Get(0xf074);

            /// <summary>
            /// Receipt
            /// </summary>
            public static IconUsage Receipt => Get(0xf543);

            /// <summary>
            /// Recycle
            /// </summary>
            public static IconUsage Recycle => Get(0xf1b8);

            /// <summary>
            /// Redo
            /// </summary>
            public static IconUsage Redo => Get(0xf01e);

            /// <summary>
            /// Alternate Redo
            /// </summary>
            public static IconUsage RedoAlt => Get(0xf2f9);

            /// <summary>
            /// Registered Trademark
            /// </summary>
            public static IconUsage Registered => Get(0xf25d);

            /// <summary>
            /// Reply
            /// </summary>
            public static IconUsage Reply => Get(0xf3e5);

            /// <summary>
            /// reply-all
            /// </summary>
            public static IconUsage ReplyAll => Get(0xf122);

            /// <summary>
            /// Republican
            /// </summary>
            public static IconUsage Republican => Get(0xf75e);

            /// <summary>
            /// Restroom
            /// </summary>
            public static IconUsage Restroom => Get(0xf7bd);

            /// <summary>
            /// Retweet
            /// </summary>
            public static IconUsage Retweet => Get(0xf079);

            /// <summary>
            /// Ribbon
            /// </summary>
            public static IconUsage Ribbon => Get(0xf4d6);

            /// <summary>
            /// Ring
            /// </summary>
            public static IconUsage Ring => Get(0xf70b);

            /// <summary>
            /// road
            /// </summary>
            public static IconUsage Road => Get(0xf018);

            /// <summary>
            /// Robot
            /// </summary>
            public static IconUsage Robot => Get(0xf544);

            /// <summary>
            /// rocket
            /// </summary>
            public static IconUsage Rocket => Get(0xf135);

            /// <summary>
            /// Route
            /// </summary>
            public static IconUsage Route => Get(0xf4d7);

            /// <summary>
            /// rss
            /// </summary>
            public static IconUsage Rss => Get(0xf09e);

            /// <summary>
            /// RSS Square
            /// </summary>
            public static IconUsage RssSquare => Get(0xf143);

            /// <summary>
            /// Ruble Sign
            /// </summary>
            public static IconUsage RubleSign => Get(0xf158);

            /// <summary>
            /// Ruler
            /// </summary>
            public static IconUsage Ruler => Get(0xf545);

            /// <summary>
            /// Ruler Combined
            /// </summary>
            public static IconUsage RulerCombined => Get(0xf546);

            /// <summary>
            /// Ruler Horizontal
            /// </summary>
            public static IconUsage RulerHorizontal => Get(0xf547);

            /// <summary>
            /// Ruler Vertical
            /// </summary>
            public static IconUsage RulerVertical => Get(0xf548);

            /// <summary>
            /// Running
            /// </summary>
            public static IconUsage Running => Get(0xf70c);

            /// <summary>
            /// Indian Rupee Sign
            /// </summary>
            public static IconUsage RupeeSign => Get(0xf156);

            /// <summary>
            /// Crying Face
            /// </summary>
            public static IconUsage SadCry => Get(0xf5b3);

            /// <summary>
            /// Loudly Crying Face
            /// </summary>
            public static IconUsage SadTear => Get(0xf5b4);

            /// <summary>
            /// Satellite
            /// </summary>
            public static IconUsage Satellite => Get(0xf7bf);

            /// <summary>
            /// Satellite Dish
            /// </summary>
            public static IconUsage SatelliteDish => Get(0xf7c0);

            /// <summary>
            /// Save
            /// </summary>
            public static IconUsage Save => Get(0xf0c7);

            /// <summary>
            /// School
            /// </summary>
            public static IconUsage School => Get(0xf549);

            /// <summary>
            /// Screwdriver
            /// </summary>
            public static IconUsage Screwdriver => Get(0xf54a);

            /// <summary>
            /// Scroll
            /// </summary>
            public static IconUsage Scroll => Get(0xf70e);

            /// <summary>
            /// Sd Card
            /// </summary>
            public static IconUsage SdCard => Get(0xf7c2);

            /// <summary>
            /// Search
            /// </summary>
            public static IconUsage Search => Get(0xf002);

            /// <summary>
            /// Search Dollar
            /// </summary>
            public static IconUsage SearchDollar => Get(0xf688);

            /// <summary>
            /// Search Location
            /// </summary>
            public static IconUsage SearchLocation => Get(0xf689);

            /// <summary>
            /// Search Minus
            /// </summary>
            public static IconUsage SearchMinus => Get(0xf010);

            /// <summary>
            /// Search Plus
            /// </summary>
            public static IconUsage SearchPlus => Get(0xf00e);

            /// <summary>
            /// Seedling
            /// </summary>
            public static IconUsage Seedling => Get(0xf4d8);

            /// <summary>
            /// Server
            /// </summary>
            public static IconUsage Server => Get(0xf233);

            /// <summary>
            /// Shapes
            /// </summary>
            public static IconUsage Shapes => Get(0xf61f);

            /// <summary>
            /// Share
            /// </summary>
            public static IconUsage Share => Get(0xf064);

            /// <summary>
            /// Alternate Share
            /// </summary>
            public static IconUsage ShareAlt => Get(0xf1e0);

            /// <summary>
            /// Alternate Share Square
            /// </summary>
            public static IconUsage ShareAltSquare => Get(0xf1e1);

            /// <summary>
            /// Share Square
            /// </summary>
            public static IconUsage ShareSquare => Get(0xf14d);

            /// <summary>
            /// Shekel Sign
            /// </summary>
            public static IconUsage ShekelSign => Get(0xf20b);

            /// <summary>
            /// Alternate Shield
            /// </summary>
            public static IconUsage ShieldAlt => Get(0xf3ed);

            /// <summary>
            /// Ship
            /// </summary>
            public static IconUsage Ship => Get(0xf21a);

            /// <summary>
            /// Shipping Fast
            /// </summary>
            public static IconUsage ShippingFast => Get(0xf48b);

            /// <summary>
            /// Shoe Prints
            /// </summary>
            public static IconUsage ShoePrints => Get(0xf54b);

            /// <summary>
            /// Shopping Bag
            /// </summary>
            public static IconUsage ShoppingBag => Get(0xf290);

            /// <summary>
            /// Shopping Basket
            /// </summary>
            public static IconUsage ShoppingBasket => Get(0xf291);

            /// <summary>
            /// shopping-cart
            /// </summary>
            public static IconUsage ShoppingCart => Get(0xf07a);

            /// <summary>
            /// Shower
            /// </summary>
            public static IconUsage Shower => Get(0xf2cc);

            /// <summary>
            /// Shuttle Van
            /// </summary>
            public static IconUsage ShuttleVan => Get(0xf5b6);

            /// <summary>
            /// Sign
            /// </summary>
            public static IconUsage Sign => Get(0xf4d9);

            /// <summary>
            /// Alternate Sign In
            /// </summary>
            public static IconUsage SignInAlt => Get(0xf2f6);

            /// <summary>
            /// Sign Language
            /// </summary>
            public static IconUsage SignLanguage => Get(0xf2a7);

            /// <summary>
            /// Alternate Sign Out
            /// </summary>
            public static IconUsage SignOutAlt => Get(0xf2f5);

            /// <summary>
            /// signal
            /// </summary>
            public static IconUsage Signal => Get(0xf012);

            /// <summary>
            /// Signature
            /// </summary>
            public static IconUsage Signature => Get(0xf5b7);

            /// <summary>
            /// SIM Card
            /// </summary>
            public static IconUsage SimCard => Get(0xf7c4);

            /// <summary>
            /// Sitemap
            /// </summary>
            public static IconUsage Sitemap => Get(0xf0e8);

            /// <summary>
            /// Skating
            /// </summary>
            public static IconUsage Skating => Get(0xf7c5);

            /// <summary>
            /// Skiing
            /// </summary>
            public static IconUsage Skiing => Get(0xf7c9);

            /// <summary>
            /// Skiing Nordic
            /// </summary>
            public static IconUsage SkiingNordic => Get(0xf7ca);

            /// <summary>
            /// Skull
            /// </summary>
            public static IconUsage Skull => Get(0xf54c);

            /// <summary>
            /// Skull & Crossbones
            /// </summary>
            public static IconUsage SkullCrossbones => Get(0xf714);

            /// <summary>
            /// Slash
            /// </summary>
            public static IconUsage Slash => Get(0xf715);

            /// <summary>
            /// Sleigh
            /// </summary>
            public static IconUsage Sleigh => Get(0xf7cc);

            /// <summary>
            /// Horizontal Sliders
            /// </summary>
            public static IconUsage SlidersH => Get(0xf1de);

            /// <summary>
            /// Smiling Face
            /// </summary>
            public static IconUsage Smile => Get(0xf118);

            /// <summary>
            /// Beaming Face With Smiling Eyes
            /// </summary>
            public static IconUsage SmileBeam => Get(0xf5b8);

            /// <summary>
            /// Winking Face
            /// </summary>
            public static IconUsage SmileWink => Get(0xf4da);

            /// <summary>
            /// Smog
            /// </summary>
            public static IconUsage Smog => Get(0xf75f);

            /// <summary>
            /// Smoking
            /// </summary>
            public static IconUsage Smoking => Get(0xf48d);

            /// <summary>
            /// Smoking Ban
            /// </summary>
            public static IconUsage SmokingBan => Get(0xf54d);

            /// <summary>
            /// SMS
            /// </summary>
            public static IconUsage Sms => Get(0xf7cd);

            /// <summary>
            /// Snowboarding
            /// </summary>
            public static IconUsage Snowboarding => Get(0xf7ce);

            /// <summary>
            /// Snowflake
            /// </summary>
            public static IconUsage Snowflake => Get(0xf2dc);

            /// <summary>
            /// Snowman
            /// </summary>
            public static IconUsage Snowman => Get(0xf7d0);

            /// <summary>
            /// Snowplow
            /// </summary>
            public static IconUsage Snowplow => Get(0xf7d2);

            /// <summary>
            /// Socks
            /// </summary>
            public static IconUsage Socks => Get(0xf696);

            /// <summary>
            /// Solar Panel
            /// </summary>
            public static IconUsage SolarPanel => Get(0xf5ba);

            /// <summary>
            /// Sort
            /// </summary>
            public static IconUsage Sort => Get(0xf0dc);

            /// <summary>
            /// Sort Alpha Down
            /// </summary>
            public static IconUsage SortAlphaDown => Get(0xf15d);

            /// <summary>
            /// Sort Alpha Up
            /// </summary>
            public static IconUsage SortAlphaUp => Get(0xf15e);

            /// <summary>
            /// Sort Amount Down
            /// </summary>
            public static IconUsage SortAmountDown => Get(0xf160);

            /// <summary>
            /// Sort Amount Up
            /// </summary>
            public static IconUsage SortAmountUp => Get(0xf161);

            /// <summary>
            /// Sort Down (Descending)
            /// </summary>
            public static IconUsage SortDown => Get(0xf0dd);

            /// <summary>
            /// Sort Numeric Down
            /// </summary>
            public static IconUsage SortNumericDown => Get(0xf162);

            /// <summary>
            /// Sort Numeric Up
            /// </summary>
            public static IconUsage SortNumericUp => Get(0xf163);

            /// <summary>
            /// Sort Up (Ascending)
            /// </summary>
            public static IconUsage SortUp => Get(0xf0de);

            /// <summary>
            /// Spa
            /// </summary>
            public static IconUsage Spa => Get(0xf5bb);

            /// <summary>
            /// Space Shuttle
            /// </summary>
            public static IconUsage SpaceShuttle => Get(0xf197);

            /// <summary>
            /// Spider
            /// </summary>
            public static IconUsage Spider => Get(0xf717);

            /// <summary>
            /// Spinner
            /// </summary>
            public static IconUsage Spinner => Get(0xf110);

            /// <summary>
            /// Splotch
            /// </summary>
            public static IconUsage Splotch => Get(0xf5bc);

            /// <summary>
            /// Spray Can
            /// </summary>
            public static IconUsage SprayCan => Get(0xf5bd);

            /// <summary>
            /// Square
            /// </summary>
            public static IconUsage Square => Get(0xf0c8);

            /// <summary>
            /// Square Full
            /// </summary>
            public static IconUsage SquareFull => Get(0xf45c);

            /// <summary>
            /// Alternate Square Root
            /// </summary>
            public static IconUsage SquareRootAlt => Get(0xf698);

            /// <summary>
            /// Stamp
            /// </summary>
            public static IconUsage Stamp => Get(0xf5bf);

            /// <summary>
            /// Star
            /// </summary>
            public static IconUsage Star => Get(0xf005);

            /// <summary>
            /// Star and Crescent
            /// </summary>
            public static IconUsage StarAndCrescent => Get(0xf699);

            /// <summary>
            /// star-half
            /// </summary>
            public static IconUsage StarHalf => Get(0xf089);

            /// <summary>
            /// Alternate Star Half
            /// </summary>
            public static IconUsage StarHalfAlt => Get(0xf5c0);

            /// <summary>
            /// Star of David
            /// </summary>
            public static IconUsage StarOfDavid => Get(0xf69a);

            /// <summary>
            /// Star of Life
            /// </summary>
            public static IconUsage StarOfLife => Get(0xf621);

            /// <summary>
            /// step-backward
            /// </summary>
            public static IconUsage StepBackward => Get(0xf048);

            /// <summary>
            /// step-forward
            /// </summary>
            public static IconUsage StepForward => Get(0xf051);

            /// <summary>
            /// Stethoscope
            /// </summary>
            public static IconUsage Stethoscope => Get(0xf0f1);

            /// <summary>
            /// Sticky Note
            /// </summary>
            public static IconUsage StickyNote => Get(0xf249);

            /// <summary>
            /// stop
            /// </summary>
            public static IconUsage Stop => Get(0xf04d);

            /// <summary>
            /// Stop Circle
            /// </summary>
            public static IconUsage StopCircle => Get(0xf28d);

            /// <summary>
            /// Stopwatch
            /// </summary>
            public static IconUsage Stopwatch => Get(0xf2f2);

            /// <summary>
            /// Store
            /// </summary>
            public static IconUsage Store => Get(0xf54e);

            /// <summary>
            /// Alternate Store
            /// </summary>
            public static IconUsage StoreAlt => Get(0xf54f);

            /// <summary>
            /// Stream
            /// </summary>
            public static IconUsage Stream => Get(0xf550);

            /// <summary>
            /// Street View
            /// </summary>
            public static IconUsage StreetView => Get(0xf21d);

            /// <summary>
            /// Strikethrough
            /// </summary>
            public static IconUsage Strikethrough => Get(0xf0cc);

            /// <summary>
            /// Stroopwafel
            /// </summary>
            public static IconUsage Stroopwafel => Get(0xf551);

            /// <summary>
            /// subscript
            /// </summary>
            public static IconUsage Subscript => Get(0xf12c);

            /// <summary>
            /// Subway
            /// </summary>
            public static IconUsage Subway => Get(0xf239);

            /// <summary>
            /// Suitcase
            /// </summary>
            public static IconUsage Suitcase => Get(0xf0f2);

            /// <summary>
            /// Suitcase Rolling
            /// </summary>
            public static IconUsage SuitcaseRolling => Get(0xf5c1);

            /// <summary>
            /// Sun
            /// </summary>
            public static IconUsage Sun => Get(0xf185);

            /// <summary>
            /// superscript
            /// </summary>
            public static IconUsage Superscript => Get(0xf12b);

            /// <summary>
            /// Hushed Face
            /// </summary>
            public static IconUsage Surprise => Get(0xf5c2);

            /// <summary>
            /// Swatchbook
            /// </summary>
            public static IconUsage Swatchbook => Get(0xf5c3);

            /// <summary>
            /// Swimmer
            /// </summary>
            public static IconUsage Swimmer => Get(0xf5c4);

            /// <summary>
            /// Swimming Pool
            /// </summary>
            public static IconUsage SwimmingPool => Get(0xf5c5);

            /// <summary>
            /// Synagogue
            /// </summary>
            public static IconUsage Synagogue => Get(0xf69b);

            /// <summary>
            /// Sync
            /// </summary>
            public static IconUsage Sync => Get(0xf021);

            /// <summary>
            /// Alternate Sync
            /// </summary>
            public static IconUsage SyncAlt => Get(0xf2f1);

            /// <summary>
            /// Syringe
            /// </summary>
            public static IconUsage Syringe => Get(0xf48e);

            /// <summary>
            /// table
            /// </summary>
            public static IconUsage Table => Get(0xf0ce);

            /// <summary>
            /// Table Tennis
            /// </summary>
            public static IconUsage TableTennis => Get(0xf45d);

            /// <summary>
            /// tablet
            /// </summary>
            public static IconUsage Tablet => Get(0xf10a);

            /// <summary>
            /// Alternate Tablet
            /// </summary>
            public static IconUsage TabletAlt => Get(0xf3fa);

            /// <summary>
            /// Tablets
            /// </summary>
            public static IconUsage Tablets => Get(0xf490);

            /// <summary>
            /// Alternate Tachometer
            /// </summary>
            public static IconUsage TachometerAlt => Get(0xf3fd);

            /// <summary>
            /// tag
            /// </summary>
            public static IconUsage Tag => Get(0xf02b);

            /// <summary>
            /// tags
            /// </summary>
            public static IconUsage Tags => Get(0xf02c);

            /// <summary>
            /// Tape
            /// </summary>
            public static IconUsage Tape => Get(0xf4db);

            /// <summary>
            /// Tasks
            /// </summary>
            public static IconUsage Tasks => Get(0xf0ae);

            /// <summary>
            /// Taxi
            /// </summary>
            public static IconUsage Taxi => Get(0xf1ba);

            /// <summary>
            /// Teeth
            /// </summary>
            public static IconUsage Teeth => Get(0xf62e);

            /// <summary>
            /// Teeth Open
            /// </summary>
            public static IconUsage TeethOpen => Get(0xf62f);

            /// <summary>
            /// High Temperature
            /// </summary>
            public static IconUsage TemperatureHigh => Get(0xf769);

            /// <summary>
            /// Low Temperature
            /// </summary>
            public static IconUsage TemperatureLow => Get(0xf76b);

            /// <summary>
            /// Tenge
            /// </summary>
            public static IconUsage Tenge => Get(0xf7d7);

            /// <summary>
            /// Terminal
            /// </summary>
            public static IconUsage Terminal => Get(0xf120);

            /// <summary>
            /// text-height
            /// </summary>
            public static IconUsage TextHeight => Get(0xf034);

            /// <summary>
            /// text-width
            /// </summary>
            public static IconUsage TextWidth => Get(0xf035);

            /// <summary>
            /// th
            /// </summary>
            public static IconUsage Th => Get(0xf00a);

            /// <summary>
            /// th-large
            /// </summary>
            public static IconUsage ThLarge => Get(0xf009);

            /// <summary>
            /// th-list
            /// </summary>
            public static IconUsage ThList => Get(0xf00b);

            /// <summary>
            /// Theater Masks
            /// </summary>
            public static IconUsage TheaterMasks => Get(0xf630);

            /// <summary>
            /// Thermometer
            /// </summary>
            public static IconUsage Thermometer => Get(0xf491);

            /// <summary>
            /// Thermometer Empty
            /// </summary>
            public static IconUsage ThermometerEmpty => Get(0xf2cb);

            /// <summary>
            /// Thermometer Full
            /// </summary>
            public static IconUsage ThermometerFull => Get(0xf2c7);

            /// <summary>
            /// Thermometer 1/2 Full
            /// </summary>
            public static IconUsage ThermometerHalf => Get(0xf2c9);

            /// <summary>
            /// Thermometer 1/4 Full
            /// </summary>
            public static IconUsage ThermometerQuarter => Get(0xf2ca);

            /// <summary>
            /// Thermometer 3/4 Full
            /// </summary>
            public static IconUsage ThermometerThreeQuarters => Get(0xf2c8);

            /// <summary>
            /// thumbs-down
            /// </summary>
            public static IconUsage ThumbsDown => Get(0xf165);

            /// <summary>
            /// thumbs-up
            /// </summary>
            public static IconUsage ThumbsUp => Get(0xf164);

            /// <summary>
            /// Thumbtack
            /// </summary>
            public static IconUsage Thumbtack => Get(0xf08d);

            /// <summary>
            /// Alternate Ticket
            /// </summary>
            public static IconUsage TicketAlt => Get(0xf3ff);

            /// <summary>
            /// Times
            /// </summary>
            public static IconUsage Times => Get(0xf00d);

            /// <summary>
            /// Times Circle
            /// </summary>
            public static IconUsage TimesCircle => Get(0xf057);

            /// <summary>
            /// tint
            /// </summary>
            public static IconUsage Tint => Get(0xf043);

            /// <summary>
            /// Tint Slash
            /// </summary>
            public static IconUsage TintSlash => Get(0xf5c7);

            /// <summary>
            /// Tired Face
            /// </summary>
            public static IconUsage Tired => Get(0xf5c8);

            /// <summary>
            /// Toggle Off
            /// </summary>
            public static IconUsage ToggleOff => Get(0xf204);

            /// <summary>
            /// Toggle On
            /// </summary>
            public static IconUsage ToggleOn => Get(0xf205);

            /// <summary>
            /// Toilet
            /// </summary>
            public static IconUsage Toilet => Get(0xf7d8);

            /// <summary>
            /// Toilet Paper
            /// </summary>
            public static IconUsage ToiletPaper => Get(0xf71e);

            /// <summary>
            /// Toolbox
            /// </summary>
            public static IconUsage Toolbox => Get(0xf552);

            /// <summary>
            /// Tools
            /// </summary>
            public static IconUsage Tools => Get(0xf7d9);

            /// <summary>
            /// Tooth
            /// </summary>
            public static IconUsage Tooth => Get(0xf5c9);

            /// <summary>
            /// Torah
            /// </summary>
            public static IconUsage Torah => Get(0xf6a0);

            /// <summary>
            /// Torii Gate
            /// </summary>
            public static IconUsage ToriiGate => Get(0xf6a1);

            /// <summary>
            /// Tractor
            /// </summary>
            public static IconUsage Tractor => Get(0xf722);

            /// <summary>
            /// Trademark
            /// </summary>
            public static IconUsage Trademark => Get(0xf25c);

            /// <summary>
            /// Traffic Light
            /// </summary>
            public static IconUsage TrafficLight => Get(0xf637);

            /// <summary>
            /// Train
            /// </summary>
            public static IconUsage Train => Get(0xf238);

            /// <summary>
            /// Tram
            /// </summary>
            public static IconUsage Tram => Get(0xf7da);

            /// <summary>
            /// Transgender
            /// </summary>
            public static IconUsage Transgender => Get(0xf224);

            /// <summary>
            /// Alternate Transgender
            /// </summary>
            public static IconUsage TransgenderAlt => Get(0xf225);

            /// <summary>
            /// Trash
            /// </summary>
            public static IconUsage Trash => Get(0xf1f8);

            /// <summary>
            /// Alternate Trash
            /// </summary>
            public static IconUsage TrashAlt => Get(0xf2ed);

            /// <summary>
            /// Trash Restore
            /// </summary>
            public static IconUsage TrashRestore => Get(0xf829);

            /// <summary>
            /// Alternative Trash Restore
            /// </summary>
            public static IconUsage TrashRestoreAlt => Get(0xf82a);

            /// <summary>
            /// Tree
            /// </summary>
            public static IconUsage Tree => Get(0xf1bb);

            /// <summary>
            /// trophy
            /// </summary>
            public static IconUsage Trophy => Get(0xf091);

            /// <summary>
            /// truck
            /// </summary>
            public static IconUsage Truck => Get(0xf0d1);

            /// <summary>
            /// Truck Loading
            /// </summary>
            public static IconUsage TruckLoading => Get(0xf4de);

            /// <summary>
            /// Truck Monster
            /// </summary>
            public static IconUsage TruckMonster => Get(0xf63b);

            /// <summary>
            /// Truck Moving
            /// </summary>
            public static IconUsage TruckMoving => Get(0xf4df);

            /// <summary>
            /// Truck Side
            /// </summary>
            public static IconUsage TruckPickup => Get(0xf63c);

            /// <summary>
            /// T-Shirt
            /// </summary>
            public static IconUsage Tshirt => Get(0xf553);

            /// <summary>
            /// TTY
            /// </summary>
            public static IconUsage Tty => Get(0xf1e4);

            /// <summary>
            /// Television
            /// </summary>
            public static IconUsage Tv => Get(0xf26c);

            /// <summary>
            /// Umbrella
            /// </summary>
            public static IconUsage Umbrella => Get(0xf0e9);

            /// <summary>
            /// Umbrella Beach
            /// </summary>
            public static IconUsage UmbrellaBeach => Get(0xf5ca);

            /// <summary>
            /// Underline
            /// </summary>
            public static IconUsage Underline => Get(0xf0cd);

            /// <summary>
            /// Undo
            /// </summary>
            public static IconUsage Undo => Get(0xf0e2);

            /// <summary>
            /// Alternate Undo
            /// </summary>
            public static IconUsage UndoAlt => Get(0xf2ea);

            /// <summary>
            /// Universal Access
            /// </summary>
            public static IconUsage UniversalAccess => Get(0xf29a);

            /// <summary>
            /// University
            /// </summary>
            public static IconUsage University => Get(0xf19c);

            /// <summary>
            /// unlink
            /// </summary>
            public static IconUsage Unlink => Get(0xf127);

            /// <summary>
            /// unlock
            /// </summary>
            public static IconUsage Unlock => Get(0xf09c);

            /// <summary>
            /// Alternate Unlock
            /// </summary>
            public static IconUsage UnlockAlt => Get(0xf13e);

            /// <summary>
            /// Upload
            /// </summary>
            public static IconUsage Upload => Get(0xf093);

            /// <summary>
            /// User
            /// </summary>
            public static IconUsage User => Get(0xf007);

            /// <summary>
            /// Alternate User
            /// </summary>
            public static IconUsage UserAlt => Get(0xf406);

            /// <summary>
            /// Alternate User Slash
            /// </summary>
            public static IconUsage UserAltSlash => Get(0xf4fa);

            /// <summary>
            /// User Astronaut
            /// </summary>
            public static IconUsage UserAstronaut => Get(0xf4fb);

            /// <summary>
            /// User Check
            /// </summary>
            public static IconUsage UserCheck => Get(0xf4fc);

            /// <summary>
            /// User Circle
            /// </summary>
            public static IconUsage UserCircle => Get(0xf2bd);

            /// <summary>
            /// User Clock
            /// </summary>
            public static IconUsage UserClock => Get(0xf4fd);

            /// <summary>
            /// User Cog
            /// </summary>
            public static IconUsage UserCog => Get(0xf4fe);

            /// <summary>
            /// User Edit
            /// </summary>
            public static IconUsage UserEdit => Get(0xf4ff);

            /// <summary>
            /// User Friends
            /// </summary>
            public static IconUsage UserFriends => Get(0xf500);

            /// <summary>
            /// User Graduate
            /// </summary>
            public static IconUsage UserGraduate => Get(0xf501);

            /// <summary>
            /// User Injured
            /// </summary>
            public static IconUsage UserInjured => Get(0xf728);

            /// <summary>
            /// User Lock
            /// </summary>
            public static IconUsage UserLock => Get(0xf502);

            /// <summary>
            /// Doctor
            /// </summary>
            public static IconUsage UserMd => Get(0xf0f0);

            /// <summary>
            /// User Minus
            /// </summary>
            public static IconUsage UserMinus => Get(0xf503);

            /// <summary>
            /// User Ninja
            /// </summary>
            public static IconUsage UserNinja => Get(0xf504);

            /// <summary>
            /// Nurse
            /// </summary>
            public static IconUsage UserNurse => Get(0xf82f);

            /// <summary>
            /// User Plus
            /// </summary>
            public static IconUsage UserPlus => Get(0xf234);

            /// <summary>
            /// User Secret
            /// </summary>
            public static IconUsage UserSecret => Get(0xf21b);

            /// <summary>
            /// User Shield
            /// </summary>
            public static IconUsage UserShield => Get(0xf505);

            /// <summary>
            /// User Slash
            /// </summary>
            public static IconUsage UserSlash => Get(0xf506);

            /// <summary>
            /// User Tag
            /// </summary>
            public static IconUsage UserTag => Get(0xf507);

            /// <summary>
            /// User Tie
            /// </summary>
            public static IconUsage UserTie => Get(0xf508);

            /// <summary>
            /// Remove User
            /// </summary>
            public static IconUsage UserTimes => Get(0xf235);

            /// <summary>
            /// Users
            /// </summary>
            public static IconUsage Users => Get(0xf0c0);

            /// <summary>
            /// Users Cog
            /// </summary>
            public static IconUsage UsersCog => Get(0xf509);

            /// <summary>
            /// Utensil Spoon
            /// </summary>
            public static IconUsage UtensilSpoon => Get(0xf2e5);

            /// <summary>
            /// Utensils
            /// </summary>
            public static IconUsage Utensils => Get(0xf2e7);

            /// <summary>
            /// Vector Square
            /// </summary>
            public static IconUsage VectorSquare => Get(0xf5cb);

            /// <summary>
            /// Venus
            /// </summary>
            public static IconUsage Venus => Get(0xf221);

            /// <summary>
            /// Venus Double
            /// </summary>
            public static IconUsage VenusDouble => Get(0xf226);

            /// <summary>
            /// Venus Mars
            /// </summary>
            public static IconUsage VenusMars => Get(0xf228);

            /// <summary>
            /// Vial
            /// </summary>
            public static IconUsage Vial => Get(0xf492);

            /// <summary>
            /// Vials
            /// </summary>
            public static IconUsage Vials => Get(0xf493);

            /// <summary>
            /// Video
            /// </summary>
            public static IconUsage Video => Get(0xf03d);

            /// <summary>
            /// Video Slash
            /// </summary>
            public static IconUsage VideoSlash => Get(0xf4e2);

            /// <summary>
            /// Vihara
            /// </summary>
            public static IconUsage Vihara => Get(0xf6a7);

            /// <summary>
            /// Volleyball Ball
            /// </summary>
            public static IconUsage VolleyballBall => Get(0xf45f);

            /// <summary>
            /// Volume Down
            /// </summary>
            public static IconUsage VolumeDown => Get(0xf027);

            /// <summary>
            /// Volume Mute
            /// </summary>
            public static IconUsage VolumeMute => Get(0xf6a9);

            /// <summary>
            /// Volume Off
            /// </summary>
            public static IconUsage VolumeOff => Get(0xf026);

            /// <summary>
            /// Volume Up
            /// </summary>
            public static IconUsage VolumeUp => Get(0xf028);

            /// <summary>
            /// Vote Yea
            /// </summary>
            public static IconUsage VoteYea => Get(0xf772);

            /// <summary>
            /// Cardboard VR
            /// </summary>
            public static IconUsage VrCardboard => Get(0xf729);

            /// <summary>
            /// Walking
            /// </summary>
            public static IconUsage Walking => Get(0xf554);

            /// <summary>
            /// Wallet
            /// </summary>
            public static IconUsage Wallet => Get(0xf555);

            /// <summary>
            /// Warehouse
            /// </summary>
            public static IconUsage Warehouse => Get(0xf494);

            /// <summary>
            /// Water
            /// </summary>
            public static IconUsage Water => Get(0xf773);

            /// <summary>
            /// Square Wave
            /// </summary>
            public static IconUsage WaveSquare => Get(0xf83e);

            /// <summary>
            /// Weight
            /// </summary>
            public static IconUsage Weight => Get(0xf496);

            /// <summary>
            /// Hanging Weight
            /// </summary>
            public static IconUsage WeightHanging => Get(0xf5cd);

            /// <summary>
            /// Wheelchair
            /// </summary>
            public static IconUsage Wheelchair => Get(0xf193);

            /// <summary>
            /// WiFi
            /// </summary>
            public static IconUsage Wifi => Get(0xf1eb);

            /// <summary>
            /// Wind
            /// </summary>
            public static IconUsage Wind => Get(0xf72e);

            /// <summary>
            /// Window Close
            /// </summary>
            public static IconUsage WindowClose => Get(0xf410);

            /// <summary>
            /// Window Maximize
            /// </summary>
            public static IconUsage WindowMaximize => Get(0xf2d0);

            /// <summary>
            /// Window Minimize
            /// </summary>
            public static IconUsage WindowMinimize => Get(0xf2d1);

            /// <summary>
            /// Window Restore
            /// </summary>
            public static IconUsage WindowRestore => Get(0xf2d2);

            /// <summary>
            /// Wine Bottle
            /// </summary>
            public static IconUsage WineBottle => Get(0xf72f);

            /// <summary>
            /// Wine Glass
            /// </summary>
            public static IconUsage WineGlass => Get(0xf4e3);

            /// <summary>
            /// Alternate Wine Glas
            /// </summary>
            public static IconUsage WineGlassAlt => Get(0xf5ce);

            /// <summary>
            /// Won Sign
            /// </summary>
            public static IconUsage WonSign => Get(0xf159);

            /// <summary>
            /// Wrench
            /// </summary>
            public static IconUsage Wrench => Get(0xf0ad);

            /// <summary>
            /// X-Ray
            /// </summary>
            public static IconUsage XRay => Get(0xf497);

            /// <summary>
            /// Yen Sign
            /// </summary>
            public static IconUsage YenSign => Get(0xf157);

            /// <summary>
            /// Yin Yang
            /// </summary>
            public static IconUsage YinYang => Get(0xf6ad);
        }
    }
}
