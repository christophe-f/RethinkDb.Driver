












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Table : ReqlExpr {

    
    
    
/// <summary>
/// <para>Select all documents in a table. This command can be chained with other commands to do
/// further processing on the data.</para>
/// </summary>
/// <example><para>Example: Return all documents in the table 'marvel' of the default database.</para>
/// <code>r.table('marvel').run(conn, callback)
/// </code></example>
        public Table (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Select all documents in a table. This command can be chained with other commands to do
/// further processing on the data.</para>
/// </summary>
/// <example><para>Example: Return all documents in the table 'marvel' of the default database.</para>
/// <code>r.table('marvel').run(conn, callback)
/// </code></example>
        public Table (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Select all documents in a table. This command can be chained with other commands to do
/// further processing on the data.</para>
/// </summary>
/// <example><para>Example: Return all documents in the table 'marvel' of the default database.</para>
/// <code>r.table('marvel').run(conn, callback)
/// </code></example>
        public Table (Arguments args, OptArgs optargs)
             : this(TermType.TABLE, args, optargs) {
        }

    protected Table (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    
///<summary>
/// "read_mode": "E_READ_MODE",
///  "identifier_format": "E_IDENTIFIER_FORMAT"
///</summary>
        public Table optArg(string optname, object value) {
             var newOptargs = OptArgs.fromMap(this.OptArgs)
                                     .with(optname, value);
             return new Table (this.Args, newOptargs);
        }


    

    

/// <summary>
/// <para>Get a document by primary key.</para>
/// <para>If no document exists with that primary key, <code>get</code> will return <code>null</code>.</para>
/// </summary>
/// <example><para>Example: Find a document by UUID.</para>
/// <code>r.table('posts').get('a9849eef-7176-4411-935b-79a6e3c56a74').run(conn, callback)
/// </code></example>
                        public Get get ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new Get (arguments);
                        }
/// <summary>
/// <para>Get all documents where the given value matches the value of the requested index.</para>
/// </summary>
/// <example><para>Example: Secondary index keys are not guaranteed to be unique so we cannot query via <a href="/api/javascript/get/">get</a> when using a secondary index.</para>
/// <code>r.table('marvel').getAll('man_of_steel', {index:'code_name'}).run(conn, callback)
/// </code></example>
                        public GetAll getAll ( params object[] exprs )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAddAll(exprs);
                        return new GetAll (arguments);
                        }
/// <summary>
/// <para>Insert JSON documents into a table. Accepts a single JSON document or an array of
/// documents.</para>
/// </summary>
/// <example><para>Example: Insert a document into the table <code>posts</code>.</para>
/// <code>r.table("posts").insert({
///     id: 1,
///     title: "Lorem ipsum",
///     content: "Dolor sit amet"
/// }).run(conn, callback)
/// </code></example>
                        public Insert insert ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new Insert (arguments);
                        }
/// <summary>
/// <para>Query (read and/or update) the configurations for individual tables or databases.</para>
/// </summary>
/// <example><para>Example: Get the configuration for the <code>users</code> table.</para>
/// <code>&gt; r.table('users').config().run(conn, callback);
/// </code></example>
                        public Config config (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Config (arguments);
                        }
/// <summary>
/// <para>Return the status of a table.</para>
/// </summary>
/// <example><para>Example: Get a table's status.</para>
/// <code>&gt; r.table('superheroes').status().run(conn, callback);
/// </code></example>
                        public Status status (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Status (arguments);
                        }
/// <summary>
/// <para>Wait for a table or all the tables in a database to be ready. A table may be temporarily unavailable after creation, rebalancing or reconfiguring. The <code>wait</code> command blocks until the given table (or database) is fully up to date.</para>
/// </summary>
/// <example><para>Example: Wait for a table to be ready.</para>
/// <code>&gt; r.table('superheroes').wait().run(conn, callback);
/// </code></example>
                        public Wait wait_ (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Wait (arguments);
                        }
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
                        public Reconfigure reconfigure (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Reconfigure (arguments);
                        }
/// <summary>
/// <para>Rebalances the shards of a table. When called on a database, all the tables in that database will be rebalanced.</para>
/// </summary>
/// <example><para>Example: Rebalance a table.</para>
/// <code>&gt; r.table('superheroes').rebalance().run(conn, callback);
/// </code></example>
                        public Rebalance rebalance (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Rebalance (arguments);
                        }
/// <summary>
/// <para><code>sync</code> ensures that writes on a given table are written to permanent storage. Queries
/// that specify soft durability (<code>{durability: 'soft'}</code>) do not give such guarantees, so
/// <code>sync</code> can be used to ensure the state of these queries. A call to <code>sync</code> does not return
/// until all previous writes to the table are persisted.</para>
/// </summary>
/// <example><para>Example: After having updated multiple heroes with soft durability, we now want to wait
/// until these changes are persisted.</para>
/// <code>r.table('marvel').sync().run(conn, callback)
/// </code></example>
                        public Sync sync (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new Sync (arguments);
                        }
/// <summary>
/// <para>Create a new secondary index on a table.</para>
/// </summary>
/// <example><para>Example: Create a simple index based on the field <code>postId</code>.</para>
/// <code>r.table('comments').indexCreate('postId').run(conn, callback)
/// </code></example>
                        public IndexCreate indexCreate ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new IndexCreate (arguments);
                        }
/// <summary>
/// <para>Create a new secondary index on a table.</para>
/// </summary>
/// <example><para>Example: Create a simple index based on the field <code>postId</code>.</para>
/// <code>r.table('comments').indexCreate('postId').run(conn, callback)
/// </code></example>
                        public IndexCreate indexCreate ( Object expr, ReqlFunction1 func1 )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                                arguments.CoerceAndAdd(func1);
                        return new IndexCreate (arguments);
                        }
/// <summary>
/// <para>Delete a previously created secondary index of this table.</para>
/// </summary>
/// <example><para>Example: Drop a secondary index named 'code_name'.</para>
/// <code>r.table('dc').indexDrop('code_name').run(conn, callback)
/// </code></example>
                        public IndexDrop indexDrop ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new IndexDrop (arguments);
                        }
/// <summary>
/// <para>List all the secondary indexes of this table.</para>
/// </summary>
/// <example><para>Example: List the available secondary indexes for this table.</para>
/// <code>r.table('marvel').indexList().run(conn, callback)
/// </code></example>
                        public IndexList indexList (  )
                        {
                        Arguments arguments = new Arguments(this);
                        return new IndexList (arguments);
                        }
/// <summary>
/// <para>Get the status of the specified indexes on this table, or the status
/// of all indexes on this table if no indexes are specified.</para>
/// </summary>
/// <example><para>Example: Get the status of all the indexes on <code>test</code>:</para>
/// <code>r.table('test').indexStatus().run(conn, callback)
/// </code>
/// <para>Example: Get the status of the <code>timestamp</code> index:</para>
/// <code>r.table('test').indexStatus('timestamp').run(conn, callback)
/// </code></example>
                        public IndexStatus indexStatus ( params object[] exprs )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAddAll(exprs);
                        return new IndexStatus (arguments);
                        }
/// <summary>
/// <para>Wait for the specified indexes on this table to be ready, or for all
/// indexes on this table to be ready if no indexes are specified.</para>
/// </summary>
/// <example><para>Example: Wait for all indexes on the table <code>test</code> to be ready:</para>
/// <code>r.table('test').indexWait().run(conn, callback)
/// </code>
/// <para>Example: Wait for the index <code>timestamp</code> to be ready:</para>
/// <code>r.table('test').indexWait('timestamp').run(conn, callback)
/// </code></example>
                        public IndexWait indexWait ( params object[] exprs )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAddAll(exprs);
                        return new IndexWait (arguments);
                        }
/// <summary>
/// <para>Rename an existing secondary index on a table. If the optional argument <code>overwrite</code> is specified as <code>true</code>, a previously existing index with the new name will be deleted and the index will be renamed. If <code>overwrite</code> is <code>false</code> (the default) an error will be raised if the new index name already exists.</para>
/// </summary>
/// <example><para>Example: Rename an index on the comments table.</para>
/// <code>r.table('comments').indexRename('postId', 'messageId').run(conn, callback)
/// </code></example>
                        public IndexRename indexRename ( Object expr, Object exprA )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                                arguments.CoerceAndAdd(exprA);
                        return new IndexRename (arguments);
                        }
/// <summary>
/// <para>Get all documents where the given geometry object intersects the geometry object of the requested geospatial index.</para>
/// </summary>
/// <example><para>Example: Which of the locations in a list of parks intersect <code>circle1</code>?</para>
/// <code>var circle1 = r.circle([-117.220406,32.719464], 10, {unit: 'mi'});
/// r.table('parks').getIntersecting(circle1, {index: 'area'}).run(conn, callback);
/// </code></example>
                        public GetIntersecting getIntersecting ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new GetIntersecting (arguments);
                        }
/// <summary>
/// <para>Get all documents where the specified geospatial index is within a certain distance of the specified point (default 100 kilometers).</para>
/// </summary>
/// <example><para>Example: Return a list of enemy hideouts within 5000 meters of the secret base.</para>
/// <code>var secretBase = r.point(-122.422876,37.777128);
/// r.table('hideouts').getNearest(secretBase,
///     {index: 'location', maxDist: 5000}
/// ).run(conn, callback)
/// </code></example>
                        public GetNearest getNearest ( Object expr )
                        {
                        Arguments arguments = new Arguments(this);
                                arguments.CoerceAndAdd(expr);
                        return new GetNearest (arguments);
                        }

    
    }
}
