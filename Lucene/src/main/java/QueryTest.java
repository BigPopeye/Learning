import java.nio.file.Paths;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.apache.lucene.analysis.Analyzer;
import org.apache.lucene.analysis.standard.StandardAnalyzer;
import org.apache.lucene.document.Document;
import org.apache.lucene.index.DirectoryReader;
import org.apache.lucene.index.IndexReader;

import org.apache.lucene.index.Term;
import org.apache.lucene.queryparser.classic.QueryParser;
import org.apache.lucene.search.*;
import org.apache.lucene.store.Directory;
import org.apache.lucene.store.FSDirectory;

public class QueryTest {
    public void testJavaNotDotNet() throws Exception {
       // BooleanQuery apiQuery = new BooleanQuery();
        BooleanQuery.Builder apiQuery = new BooleanQuery.Builder();
        apiQuery.add(new TermQuery(new Term("contents", "java")), BooleanClause.Occur.MUST);
        apiQuery.add(new TermQuery(new Term("contents", "net")), BooleanClause.Occur.MUST);
        apiQuery.add(new TermQuery(new Term("contents", "dot")), BooleanClause.Occur.MUST_NOT);
        Query qpQuery = new QueryParser( "contents", new StandardAnalyzer()).parse("java AND net NOT dot");
        // Query and subclasses behave as expected with .equals
        assertEquals(qpQuery, apiQuery);
    }

    public void testToString() throws Exception {
        Query query = new QueryParser( "contents", new StandardAnalyzer()).parse("java AND net NOT dot");
        assertEquals("+java +net -dot", query.toString("contents"));
        assertEquals("+contents:java +contents:net -contents:dot", query.toString());
    }

    public static void main(String[] args) throws Exception {
        QueryTest queryTest = new QueryTest();

        //queryTest.testJavaNotDotNet();
        queryTest.testToString();
    }
}
