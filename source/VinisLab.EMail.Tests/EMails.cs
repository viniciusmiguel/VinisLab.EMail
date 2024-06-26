﻿namespace VinisLab.EMail.Tests;

public static class EMails
{
    public static string[] AllTopLevelDomains =
    [
        "a@example.com",
        "ab@example.org",
        "abc@example.net",
        "abcd@sub.example.com",
        "abcde@domain.co",
        "abcdef@domain.com",
        "abcdefg+tag@domain.com",
        "abcdefgh.lastname@domain.com",
        "abcdefghi@domain-one.com",
        "abcdefghij@domain.name",
        "abcdefghijk@domain.co.jp",
        "abcdefghijkl@domain.com",
        "\"abcdefghijklm\"@domain.com",
        "\"abcdefghijklmn.with+symbol\"@domain.com",
        "\"abcdefghijklmno.email\"@example.com",
        "abcdefghijklmnop@[IPv6:2001:db8::1]",
        "abcdefghijklmnopq@sub-domain.example.com",
        "abcdefghijklmnopqr@domain-with-dash.com",
        "abcdefghijklmnopqrst@domain.with.multiple.parts",
        "abcdefghijklmnopqrstu@example.com",
        "abcdefghijklmnopqrstuv.style.email.with+symbol@example.com",
        "abcdefghijklmnopqrstuvw.email-with-hyphen@example.com",
        "abcdefghijklmnopqrstuvwx@example.com",
        "abcdefghijklmnopqrstuvwy.name+tag+sorting@example.com",
        "z@example.com",
        "example-indeed@strange-example.com",
        "user@[123.123.123.123]",
        "example@valid.address",
        "email@domain.cc",
        "test@domain.email",
        "user@domain.info",
        "test.user@domain.museum",
        "user@domain.asia",
        "email@domain.pro",
        "firstname+lastname@domain.travel",
        "user@domain.jobs",
        "user@domain.tel",
        "example@domain.biz",
        "email@domain.int",
        "email@domain.aero",
        "user@domain.cat",
        "user@domain.coop",
        "user@domain.mobi",
        "user@domain.name",
        "user@domain.post",
        "user@domain.pub",
        "first.last@domain.com",
        "email@subdomain.example.com",
        "firstname+lastname@sub.domain.com",
        "\"first.last\"@domain.com",
        "user.name@domain.com",
        "email@domain.with.dots",
        "email@sub-domain.with-dots.com",
        "user@hyphen-domain.com",
        "john.doe@example.com",
        "jane.doe@example.org",
        "user123@example.net",
        "alice.bob@example.co",
        "charlie@example.int",
        "test.email@example.edu",
        "email+tag@example.gov",
        "firstname.lastname@example.mil",
        "email@example.cc",
        "email@example.ac",
        "email@example.ad",
        "email@example.ae",
        "email@example.af",
        "email@example.ag",
        "email@example.ai",
        "email@example.al",
        "email@example.am",
        "email@example.an",
        "email@example.ao",
        "email@example.aq",
        "email@example.ar",
        "email@example.as",
        "email@example.at",
        "email@example.au",
        "email@example.aw",
        "email@example.ax",
        "email@example.az",
        "email@example.ba",
        "email@example.bb",
        "email@example.bd",
        "email@example.be",
        "email@example.bf",
        "email@example.bg",
        "email@example.bh",
        "email@example.bi",
        "email@example.bj",
        "email@example.bl",
        "email@example.bm",
        "email@example.bn",
        "email@example.bo",
        "email@example.bq",
        "email@example.br",
        "email@example.bs",
        "email@example.bt",
        "email@example.bv",
        "email@example.bw",
        "email@example.by",
        "email@example.bz",
        "email@example.ca",
        "email@example.cd",
        "email@example.cf",
        "email@example.cg",
        "email@example.ch",
        "email@example.ci",
        "email@example.ck",
        "email@example.cl",
        "email@example.cm",
        "email@example.cn",
        "email@example.co",
        "email@example.cr",
        "email@example.cu",
        "email@example.cv",
        "email@example.cw",
        "email@example.cx",
        "email@example.cy",
        "email@example.cz",
        "email@example.de",
        "email@example.dj",
        "email@example.dk",
        "email@example.dm",
        "email@example.do",
        "email@example.dz",
        "email@example.ec",
        "email@example.ee",
        "email@example.eg",
        "email@example.er",
        "email@example.es",
        "email@example.et",
        "email@example.eu",
        "email@example.fi",
        "email@example.fj",
        "email@example.fk",
        "email@example.fm",
        "email@example.fo",
        "email@example.fr",
        "email@example.ga",
        "email@example.gb",
        "email@example.gd",
        "email@example.ge",
        "email@example.gf",
        "email@example.gg",
        "email@example.gh",
        "email@example.gi",
        "email@example.gl",
        "email@example.gm",
        "email@example.gn",
        "email@example.gp",
        "email@example.gq",
        "email@example.gr",
        "email@example.gs",
        "email@example.gt",
        "email@example.gu",
        "email@example.gw",
        "email@example.gy",
        "email@example.hk",
        "email@example.hm",
        "email@example.hn",
        "email@example.hr",
        "email@example.ht",
        "email@example.hu",
        "email@example.id",
        "email@example.ie",
        "email@example.il",
        "email@example.im",
        "email@example.in",
        "email@example.io",
        "email@example.iq",
        "email@example.ir",
        "email@example.is",
        "email@example.it",
        "email@example.je",
        "email@example.jm",
        "email@example.jo",
        "email@example.jp",
        "email@example.ke",
        "email@example.kg",
        "email@example.kh",
        "email@example.ki",
        "email@example.km",
        "email@example.kn",
        "email@example.kp",
        "email@example.kr",
        "email@example.kw",
        "email@example.ky",
        "email@example.kz",
        "email@example.la",
        "email@example.lb",
        "email@example.lc",
        "email@example.li",
        "email@example.lk",
        "email@example.lr",
        "email@example.ls",
        "email@example.lt",
        "email@example.lu",
        "email@example.lv",
        "email@example.ly",
        "email@example.ma",
        "email@example.mc",
        "email@example.md",
        "email@example.me",
        "email@example.mf",
        "email@example.mg",
        "email@example.mh",
        "email@example.mk",
        "email@example.ml",
        "email@example.mm",
        "email@example.mn",
        "email@example.mo",
        "email@example.mp",
        "email@example.mq",
        "email@example.mr",
        "email@example.ms",
        "email@example.mt",
        "email@example.mu",
        "email@example.mv",
        "email@example.mw",
        "email@example.mx",
        "email@example.my",
        "email@example.mz",
        "email@example.na",
        "email@example.nc",
        "email@example.ne",
        "email@example.nf",
        "email@example.ng",
        "email@example.ni",
        "email@example.nl",
        "email@example.no",
        "email@example.np",
        "email@example.nr",
        "email@example.nu",
        "email@example.nz",
        "email@example.om",
        "email@example.pa",
        "email@example.pe",
        "email@example.pf",
        "email@example.pg",
        "email@example.ph",
        "email@example.pk",
        "email@example.pl",
        "email@example.pm",
        "email@example.pn",
        "email@example.pr",
        "email@example.ps",
        "email@example.pt",
        "email@example.pw",
        "email@example.py",
        "email@example.qa",
        "email@example.re",
        "email@example.ro",
        "email@example.rs",
        "email@example.ru",
        "email@example.rw",
        "email@example.sa",
        "email@example.sb",
        "email@example.sc",
        "email@example.sd",
        "email@example.se",
        "email@example.sg",
        "email@example.sh",
        "email@example.si",
        "email@example.sj",
        "email@example.sk",
        "email@example.sl",
        "email@example.sm",
        "email@example.sn",
        "email@example.so",
        "email@example.sr",
        "email@example.ss",
        "email@example.st",
        "email@example.su",
        "email@example.sv",
        "email@example.sx",
        "email@example.sy",
        "email@example.sz",
        "email@example.tc",
        "email@example.td",
        "email@example.tf",
        "email@example.tg",
        "email@example.th",
        "email@example.tj",
        "email@example.tk",
        "email@example.tl",
        "email@example.tm",
        "email@example.tn",
        "email@example.to",
        "email@example.tr",
        "email@example.tt",
        "email@example.tv",
        "email@example.tw",
        "email@example.tz",
        "email@example.ua",
        "email@example.ug",
        "email@example.uk",
        "email@example.us",
        "email@example.uy",
        "email@example.uz",
        "email@example.va",
        "email@example.vc",
        "email@example.ve",
        "email@example.vg",
        "email@example.vi",
        "email@example.vn",
        "email@example.vu",
        "email@example.wf",
        "email@example.ws",
        "email@example.ye",
        "email@example.yt",
        "email@example.za",
        "email@example.zm",
        "email@example.zw",
        "user@example.aero",
        "user@example.arpa",
        "user@example.asia",
        "user@example.biz",
        "user@example.cat",
        "user@example.coop",
        "user@example.info",
        "user@example.jobs",
        "user@example.mobi",
        "user@example.museum",
        "user@example.name",
        "user@example.pro",
        "user@example.tel",
        "user@example.travel",
        "user@example.xxx",
        "user@example.academy",
        "user@example.accountant",
        "user@example.accountants",
        "user@example.actor",
        "user@example.agency",
        "user@example.airforce",
        "user@example.archi",
        "user@example.associates",
        "user@example.attorney",
        "user@example.audio",
        "user@example.autos",
        "user@example.bar",
        "user@example.bargains",
        "user@example.bike",
        "user@example.bingo",
        "user@example.boutique",
        "user@example.builders",
        "user@example.cab",
        "user@example.camera",
        "user@example.camp",
        "user@example.capital",
        "user@example.care",
        "user@example.career",
        "user@example.careers",
        "user@example.cash",
        "user@example.catering",
        "user@example.center",
        "user@example.chat",
        "user@example.cheap",
        "user@example.church",
        "user@example.city",
        "user@example.claims",
        "user@example.cleaning",
        "user@example.click",
        "user@example.clinic",
        "user@example.clothing",
        "user@example.club",
        "user@example.coach",
        "user@example.codes",
        "user@example.coffee",
        "user@example.community",
        "user@example.company",
        "user@example.computer",
        "user@example.condos",
        "user@example.construction",
        "user@example.consulting",
        "user@example.contractors",
        "user@example.cool",
        "user@example.country",
        "user@example.credits",
        "user@example.cruises",
        "user@example.dance",
        "user@example.date",
        "user@example.dating",
        "user@example.deals",
        "user@example.degree",
        "user@example.delivery",
        "user@example.democrat",
        "user@example.dentist",
        "user@example.desi",
        "user@example.diamonds",
        "user@example.digital",
        "user@example.directory",
        "user@example.discount",
        "user@example.dog",
        "user@example.domains",
        "user@example.education",
        "user@example.email",
        "user@example.engineering",
        "user@example.enterprises",
        "user@example.equipment",
        "user@example.estate",
        "user@example.events",
        "user@example.exchange",
        "user@example.expert",
        "user@example.exposed",
        "user@example.fail",
        "user@example.farm",
        "user@example.finance",
        "user@example.financial",
        "user@example.fish",
        "user@example.fitness",
        "user@example.flights",
        "user@example.florist",
        "user@example.football",
        "user@example.forsale",
        "user@example.fund",
        "user@example.furniture",
        "user@example.futbol",
        "user@example.gallery",
        "user@example.gifts",
        "user@example.glass",
        "user@example.global",
        "user@example.gripe",
        "user@example.guru",
        "user@example.haus",
        "user@example.healthcare",
        "user@example.holdings",
        "user@example.holiday",
        "user@example.horse",
        "user@example.house",
        "user@example.industries",
        "user@example.institute",
        "user@example.insure",
        "user@example.international",
        "user@example.investments",
        "user@example.jewelry",
        "user@example.kitchen",
        "user@example.land",
        "user@example.lawyer",
        "user@example.lease",
        "user@example.lgbt",
        "user@example.life",
        "user@example.lighting",
        "user@example.limited",
        "user@example.limo",
        "user@example.link",
        "user@example.loans",
        "user@example.luxury",
        "user@example.management",
        "user@example.marketing",
        "user@example.media",
        "user@example.menu",
        "user@example.mortgage",
        "user@example.navy",
        "user@example.network",
        "user@example.news",
        "user@example.ninja",
        "user@example.partners",
        "user@example.parts",
        "user@example.photography",
        "user@example.photos",
        "user@example.pics",
        "user@example.pictures",
        "user@example.plumbing",
        "user@example.productions",
        "user@example.properties",
        "user@example.recipes",
        "user@example.red",
        "user@example.rehab",
        "user@example.repair",
        "user@example.report",
        "user@example.republican",
        "user@example.rest",
        "user@example.restaurant",
        "user@example.reviews",
        "user@example.rocks",
        "user@example.singles",
        "user@example.social",
        "user@example.solar",
        "user@example.solutions",
        "user@example.supplies",
        "user@example.supply",
        "user@example.support",
        "user@example.surgery",
        "user@example.systems",
        "user@example.tax",
        "user@example.technology",
        "user@example.tienda",
        "user@example.tips",
        "user@example.today",
        "user@example.tools",
        "user@example.training",
        "user@example.university",
        "user@example.vacations",
        "user@example.vegas",
        "user@example.ventures",
        "user@example.vet",
        "user@example.viajes",
        "user@example.villas",
        "user@example.vision",
        "user@example.voyage",
        "user@example.watch",
        "user@example.webcam",
        "user@example.website",
        "user@example.wiki",
        "user@example.works",
        "user@example.zone"
        ];
    public static string[] AllInvalidEMails =
    [
        "",
        " ",
        "plainaddress",
        "@missinglocalpart.com",
        "missingatsign.com",
        "missingdot@com",
        "missingdomain@.com",
        "missingdotindomain@domaincom",
        "two@@signs.com",
        "trailingdot@domain.com.",
        ".leadingdot@domain.com",
        "double..dots@domain.com",
        "space in local@domain.com",
        "local@space in domain.com",
        "invalidchar<@domain.com",
        "invalidchar>@domain.com",
        "invalidchar,@domain.com",
        "invalidchar;@domain.com",
        "invalidchar:@domain.com",
        "invalidchar\"@domain.com",
        "invalidchar[@domain.com",
        "invalidchar\\@domain.com",
        "invalidchar]@domain.com",
        "missinglocalpart@.com",
        "missinglocalpart@com.",
        "missingdomain@domain.",
        "localpartendswith.@domain.com",
        "localpartstartswith.@domain.com",
        "two..dots@domain.com",
        "localpartendswithdot@domain.com.",
        "localpartstartswithdot@.domain.com",
        "localpartendswithdot@domain..com",
        "email@domain..com",
        "email@domain..com",
        "email@domain_with_underscore.com",
        "email@domain-with-hyphen-.com",
        "email@-domain-with-leading-hyphen.com",
        "email@domain-with-trailing-hyphen-.com",
        "email@domain_with_underscore.com",
        "email@domain-with-dash-.com",
        "email@domain..double-dot.com",
        "email@domain.com.",
        "email@.domain.com",
        "email@domain",
        "email@-domain.com",
        "email@domain-.com",
        "email@domain.c",
        "email@domain.co1",
        "email@.domain.com",
        "email@domain-.com",
        "user@.invalid",
        "user@invalid.",
        "user@domain.c_o_m",
        "user@domain.c-m",
        "user@domain.c@om",
        "user@domain.c^om",
        "user@domain.c#om",
        "user@domain.c$om",
        "user@domain.c%om",
        "user@domain.c&om",
        "user@domain.c*om",
        "user@domain.c!om",
        "user@domain.c(om",
        "user@domain.c)om",
        "user@domain.c+om",
        "user@domain.c=om",
        "user@domain.c{om",
        "user@domain.c}om",
        "user@domain.c[om",
        "user@domain.c]om",
        "user@domain.c|om",
        "user@domain.c~om",
        "user@domain.c`om",
        "user@domain.c'om",
        "user@domain.c;om",
        "user@domain.c:om",
        "user@domain.c,om",
        "user@domain.c<om",
        "user@domain.c>om",
        "user@domain.c/om",
        "user@domain.c?om",
        "user@domain.c om",
        "user@domain.c\\om",
        "user@domain.c@om",
        "user@domain.c^om",
        "user@domain.c#om",
        "user@domain.c$om",
        "user@domain.c%om",
        "user@domain.c&om",
        "user@domain.c*om",
        "user@domain.c!om",
        "user@domain.c(om",
        "user@domain.c)om",
        "user@domain.c+om",
        "user@domain.c=om",
        "user@domain.c{om",
        "user@domain.c}om",
        "user@domain.c[om",
        "user@domain.c]om",
        "user@domain.c|om",
        "user@domain.c~om",
        "user@domain.c`om",
        "user@domain.c'om"
    ];
    
}