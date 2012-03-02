/* ਀ ⨀ 䰀椀挀攀渀猀攀搀 琀漀 琀栀攀 䄀瀀愀挀栀攀 匀漀昀琀眀愀爀攀 䘀漀甀渀搀愀琀椀漀渀 ⠀䄀匀䘀⤀ 甀渀搀攀爀 漀渀攀 漀爀 洀漀爀攀 
 * contributor license agreements.  See the NOTICE file distributed with਀ ⨀ 琀栀椀猀 眀漀爀欀 昀漀爀 愀搀搀椀琀椀漀渀愀氀 椀渀昀漀爀洀愀琀椀漀渀 爀攀最愀爀搀椀渀最 挀漀瀀礀爀椀最栀琀 漀眀渀攀爀猀栀椀瀀⸀ 
 * The ASF licenses this file to You under the Apache License, Version 2.0਀ ⨀ ⠀琀栀攀 ∀䰀椀挀攀渀猀攀∀⤀㬀 礀漀甀 洀愀礀 渀漀琀 甀猀攀 琀栀椀猀 昀椀氀攀 攀砀挀攀瀀琀 椀渀 挀漀洀瀀氀椀愀渀挀攀 眀椀琀栀 
 * the License.  You may obtain a copy of the License at਀ ⨀  
 * http://www.apache.org/licenses/LICENSE-2.0਀ ⨀  
 * Unless required by applicable law or agreed to in writing, software਀ ⨀ 搀椀猀琀爀椀戀甀琀攀搀 甀渀搀攀爀 琀栀攀 䰀椀挀攀渀猀攀 椀猀 搀椀猀琀爀椀戀甀琀攀搀 漀渀 愀渀 ∀䄀匀 䤀匀∀ 䈀䄀匀䤀匀Ⰰ 
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.਀ ⨀ 匀攀攀 琀栀攀 䰀椀挀攀渀猀攀 昀漀爀 琀栀攀 猀瀀攀挀椀昀椀挀 氀愀渀最甀愀最攀 最漀瘀攀爀渀椀渀最 瀀攀爀洀椀猀猀椀漀渀猀 愀渀搀 
 * limitations under the License.਀ ⨀⼀ 
਀甀猀椀渀最 匀礀猀琀攀洀㬀 
using System.Collections.Generic;਀甀猀椀渀最 匀礀猀琀攀洀⸀吀攀砀琀㬀 
਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀匀琀漀爀攀㬀 
using Lucene.Net.Analysis;਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀䄀渀愀氀礀猀椀猀⸀吀漀欀攀渀愀琀琀爀椀戀甀琀攀猀㬀 
using Lucene.Net.Analysis.Standard;਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀䤀渀搀攀砀㬀 
using Lucene.Net.Search;਀甀猀椀渀最 䰀甀挀攀渀攀⸀一攀琀⸀䐀漀挀甀洀攀渀琀猀㬀 
using Lucene.Net.QueryParsers;਀甀猀椀渀最 一唀渀椀琀⸀䘀爀愀洀攀眀漀爀欀㬀 
਀渀愀洀攀猀瀀愀挀攀 䰀甀挀攀渀攀⸀一攀琀⸀䄀渀愀氀礀猀椀猀⸀䔀砀琀 
{਀    嬀吀攀猀琀䘀椀砀琀甀爀攀崀 
    class TestAnalysisExt਀    笀 
        [SetUp]਀        瀀甀戀氀椀挀 瘀漀椀搀 匀攀琀甀瀀⠀⤀ 
        {਀             
        }਀ 
        IndexSearcher CreateIndex(string data,Analyzer analyzer)਀        笀 
            RAMDirectory dir = new RAMDirectory();਀            䤀渀搀攀砀圀爀椀琀攀爀 眀爀 㴀 渀攀眀 䤀渀搀攀砀圀爀椀琀攀爀⠀搀椀爀Ⰰ 愀渀愀氀礀稀攀爀Ⰰ 琀爀甀攀Ⰰ 䤀渀搀攀砀圀爀椀琀攀爀⸀䴀愀砀䘀椀攀氀搀䰀攀渀最琀栀⸀唀一䰀䤀䴀䤀吀䔀䐀⤀㬀 
            Document doc = new Document();਀            搀漀挀⸀䄀搀搀⠀渀攀眀 䘀椀攀氀搀⠀∀昀椀攀氀搀∀Ⰰ 搀愀琀愀Ⰰ 䘀椀攀氀搀⸀匀琀漀爀攀⸀夀䔀匀Ⰰ 䘀椀攀氀搀⸀䤀渀搀攀砀⸀䄀一䄀䰀夀娀䔀䐀Ⰰ 䘀椀攀氀搀⸀吀攀爀洀嘀攀挀琀漀爀⸀圀䤀吀䠀开倀伀匀䤀吀䤀伀一匀开伀䘀䘀匀䔀吀匀⤀⤀㬀 
            wr.AddDocument(doc);਀            眀爀⸀䌀氀漀猀攀⠀⤀㬀 
਀            爀攀琀甀爀渀 渀攀眀 䤀渀搀攀砀匀攀愀爀挀栀攀爀⠀䤀渀搀攀砀刀攀愀搀攀爀⸀伀瀀攀渀⠀搀椀爀Ⰰ 琀爀甀攀⤀⤀㬀 
        }਀ 
        [Test]਀        瀀甀戀氀椀挀 瘀漀椀搀 吀攀猀琀匀椀渀最氀攀䌀栀愀爀吀漀欀攀渀䄀渀愀氀礀稀攀爀⠀⤀ 
        {਀            䄀渀愀氀礀稀攀爀 愀渀愀氀礀稀攀爀 㴀 渀攀眀 匀椀渀最氀攀䌀栀愀爀吀漀欀攀渀䄀渀愀氀礀稀攀爀⠀⤀㬀 
            IndexSearcher src = CreateIndex("someuser@gmail.com 1234567890 abcdefgh", analyzer);਀ 
            QueryParser p = new QueryParser(Lucene.Net.Util.Version.LUCENE_29, "field", analyzer);਀            瀀⸀匀攀琀䐀攀昀愀甀氀琀伀瀀攀爀愀琀漀爀⠀儀甀攀爀礀倀愀爀猀攀爀⸀伀瀀攀爀愀琀漀爀⸀䄀一䐀⤀㬀 
            p.SetEnablePositionIncrements(true);਀ 
            TopDocs td = null;਀ 
            td = src.Search(p.Parse("usergmail"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀　Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀最洀愀椀氀挀漀洀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(0, td.TotalHits);਀ 
            td = src.Search(p.Parse("678"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀猀漀洀攀甀猀攀爀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("omeuse"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀漀洀攀甀猀攀 㘀㜀㠀㤀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("user gmail"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀尀∀甀猀攀爀 最洀愀椀氀尀∀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("user@gmail"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀最洀愀椀氀⸀挀漀洀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("\"gmail.com 1234\""), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀尀∀最洀愀椀氀⸀挀漀洀 搀攀昀最尀∀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(0, td.TotalHits);਀ 
            td = src.Search(p.Parse("gmail.com defg"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
        }਀ 
        //[Test]਀        ⼀⼀瀀甀戀氀椀挀 瘀漀椀搀 吀攀猀琀匀椀渀最氀攀䌀栀愀爀吀漀欀攀渀䄀渀愀氀礀稀攀爀䠀椀最栀氀椀最栀琀⠀⤀ 
        //{਀        ⼀⼀    䄀渀愀氀礀稀攀爀 愀渀愀氀礀稀攀爀 㴀 渀攀眀 匀椀渀最氀攀䌀栀愀爀吀漀欀攀渀䄀渀愀氀礀稀攀爀⠀⤀㬀 
        //    IndexSearcher src = CreateIndex("someuser@gmail.com 1234567890 abcdefgh", analyzer);਀ 
        //    QueryParser p = new QueryParser(Lucene.Net.Util.Version.LUCENE_29, "field", analyzer);਀        ⼀⼀    瀀⸀匀攀琀䐀攀昀愀甀氀琀伀瀀攀爀愀琀漀爀⠀儀甀攀爀礀倀愀爀猀攀爀⸀伀瀀攀爀愀琀漀爀⸀䄀一䐀⤀㬀 
        //    p.SetMultiTermRewriteMethod(MultiTermQuery.SCORING_BOOLEAN_QUERY_REWRITE);਀ 
        //    Lucene.Net.Search.Vectorhighlight.FastVectorHighlighter fvh = new Lucene.Net.Search.Vectorhighlight.FastVectorHighlighter(true, true);਀ 
        //    Query q = null;਀        ⼀⼀    猀琀爀椀渀最嬀崀 昀爀愀最洀攀渀琀猀 㴀 渀甀氀氀㬀 
਀        ⼀⼀    焀 㴀 瀀⸀倀愀爀猀攀⠀∀挀搀攀∀⤀㬀 
        //    fragments = fvh.GetBestFragments(fvh.GetFieldQuery(q), src.GetIndexReader(), 0, "field", 256, 10);਀        ⼀⼀    䄀猀猀攀爀琀⸀䤀猀吀爀甀攀⠀昀爀愀最洀攀渀琀猀 ℀㴀 渀甀氀氀 ☀☀ 昀爀愀最洀攀渀琀猀⸀䰀攀渀最琀栀 㸀 　 ☀☀ 昀爀愀最洀攀渀琀猀嬀　崀⸀䤀渀搀攀砀伀昀⠀∀㰀戀㸀挀搀攀㰀⼀戀㸀∀⤀ 㸀㴀 　⤀㬀 
            ਀        ⼀⼀    焀 㴀 瀀⸀倀愀爀猀攀⠀∀㈀㌀㐀㔀∀⤀㬀 
        //    fragments = fvh.GetBestFragments(fvh.GetFieldQuery(q), src.GetIndexReader(), 0, "field", 256, 10);਀        ⼀⼀    䄀猀猀攀爀琀⸀䤀猀吀爀甀攀⠀昀爀愀最洀攀渀琀猀 ℀㴀 渀甀氀氀 ☀☀ 昀爀愀最洀攀渀琀猀⸀䰀攀渀最琀栀 㸀 　 ☀☀ 昀爀愀最洀攀渀琀猀嬀　崀⸀䤀渀搀攀砀伀昀⠀∀㰀戀㸀㈀㌀㐀㔀㰀⼀戀㸀∀⤀ 㸀㴀 　⤀㬀 
            ਀        ⼀⼀    焀 㴀 瀀⸀倀愀爀猀攀⠀∀最洀愀椀氀 ㄀㈀㌀㐀∀⤀㬀 
        //    fragments = fvh.GetBestFragments(fvh.GetFieldQuery(q), src.GetIndexReader(), 0, "field", 256, 10);਀        ⼀⼀    䄀猀猀攀爀琀⸀䤀猀吀爀甀攀⠀昀爀愀最洀攀渀琀猀 ℀㴀 渀甀氀氀 ☀☀ 昀爀愀最洀攀渀琀猀⸀䰀攀渀最琀栀 㸀 　 ☀☀ 昀爀愀最洀攀渀琀猀嬀　崀⸀䤀渀搀攀砀伀昀⠀∀㰀戀㸀最洀愀椀氀㰀⼀戀㸀⸀挀漀洀 㰀戀㸀㄀㈀㌀㐀㰀⼀戀㸀∀⤀ 㸀㴀 　⤀㬀 
            ਀        ⼀⼀    ⼀⨀ 
        //    q = p.Parse("gmail.com");਀        ⼀⼀    昀爀愀最洀攀渀琀猀 㴀 昀瘀栀⸀䜀攀琀䈀攀猀琀䘀爀愀最洀攀渀琀猀⠀昀瘀栀⸀䜀攀琀䘀椀攀氀搀儀甀攀爀礀⠀焀⤀Ⰰ 猀爀挀⸀䜀攀琀䤀渀搀攀砀刀攀愀搀攀爀⠀⤀Ⰰ 　Ⰰ ∀昀椀攀氀搀∀Ⰰ ㈀㔀㘀Ⰰ ㄀　⤀㬀 
        //    Assert.IsTrue(fragments != null && fragments.Length > 0 && fragments[0].IndexOf("??????????") >= 0);਀        ⼀⼀    匀礀猀琀攀洀⸀䐀椀愀最渀漀猀琀椀挀猀⸀䐀攀戀甀最⸀圀爀椀琀攀䰀椀渀攀⠀昀爀愀最洀攀渀琀猀嬀　崀⤀㬀 
        //    */਀        ⼀⼀紀 
਀        嬀吀攀猀琀崀 
        public void TestUnaccentedWordAnalyzer()਀        笀 
            TopDocs td = null;਀            猀琀爀椀渀最 琀攀砀琀 㴀 ∀一愀洀攀⸀匀甀爀渀愀洀攀䀀最洀愀椀氀⸀挀漀洀 ㄀㈀㌀⸀㐀㔀㘀 ἀﰁ开㄁─Ḁ�帀、혁윀␀鄀鈃錃鐃锃阃⌃ကᄄሄጄᐄᔄ 匀匀�∀㬀 
            string[] expectedTokens = new string[] { "name", "surname", "gmail", "com", "123", "456", "gusioc", "gusioc", "αβγδεζ" , "абвгде", "ssss"};਀ 
            UnaccentedWordAnalyzer analyzer = new UnaccentedWordAnalyzer();਀            吀漀欀攀渀匀琀爀攀愀洀 琀猀 㴀 愀渀愀氀礀稀攀爀⸀吀漀欀攀渀匀琀爀攀愀洀⠀∀∀Ⰰ 渀攀眀 匀礀猀琀攀洀⸀䤀伀⸀匀琀爀椀渀最刀攀愀搀攀爀⠀琀攀砀琀⤀⤀㬀 
            ਀            椀渀琀 椀 㴀 　㬀 
            TermAttribute termAttribute = ts.GetAttribute<TermAttribute>();਀            眀栀椀氀攀 ⠀琀猀⸀䤀渀挀爀攀洀攀渀琀吀漀欀攀渀⠀⤀⤀ 
            {਀                䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀攀砀瀀攀挀琀攀搀吀漀欀攀渀猀嬀椀⬀⬀崀Ⰰ 琀攀爀洀䄀琀琀爀椀戀甀琀攀⸀吀攀爀洀⠀⤀⤀㬀 
                System.Diagnostics.Debug.WriteLine(termAttribute.Term());਀            紀 
਀            儀甀攀爀礀倀愀爀猀攀爀 瀀 㴀 渀攀眀 儀甀攀爀礀倀愀爀猀攀爀⠀䰀甀挀攀渀攀⸀一攀琀⸀唀琀椀氀⸀嘀攀爀猀椀漀渀⸀䰀唀䌀䔀一䔀开㈀㤀Ⰰ ∀昀椀攀氀搀∀Ⰰ 愀渀愀氀礀稀攀爀⤀㬀 
            IndexSearcher src = CreateIndex(text, analyzer);਀             
            td = src.Search(p.Parse("ĞÜŞıöç"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀渀愀洀攀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("surname"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀一䄀䴀䔀⸀猀甀爀渀愀洀攀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀ 
            td = src.Search(p.Parse("surname@gmail"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀渀愀洀攀䀀最洀愀椀氀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(0, td.TotalHits);਀ 
            td = src.Search(p.Parse("456"), 10);਀            䄀猀猀攀爀琀⸀䄀爀攀䔀焀甀愀氀⠀㄀Ⰰ 琀搀⸀吀漀琀愀氀䠀椀琀猀⤀㬀 
਀            琀搀 㴀 猀爀挀⸀匀攀愀爀挀栀⠀瀀⸀倀愀爀猀攀⠀∀㄀㈀㌀⸀㐀㔀㘀∀⤀Ⰰ ㄀　⤀㬀 
            Assert.AreEqual(1, td.TotalHits);਀        紀 
    }਀紀 
