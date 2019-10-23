select * from Tms_Order;

SELECT
     C.name as [字段名],T.name as [字段类型]
     ,convert(bit,C.IsNullable)  as [可否为空]
     ,convert(bit,case when exists(SELECT 1 FROM sysobjects where xtype='PK' and parent_obj=c.id and name in (
         SELECT name FROM sysindexes WHERE indid in(
             SELECT indid FROM sysindexkeys WHERE id = c.id AND colid=c.colid))) then 1 else 0 end) 
                 as [是否主键]
     ,convert(bit,COLUMNPROPERTY(c.id,c.name,'IsIdentity')) as [自动增长]
     ,C.Length as [占用字节] 
     ,COLUMNPROPERTY(C.id,C.name,'PRECISION') as [长度]
     ,isnull(COLUMNPROPERTY(c.id,c.name,'Scale'),0) as [小数位数]
     ,ISNULL(CM.text,'') as [默认值]
     ,isnull(ETP.value,'') AS [字段描述]
     --,ROW_NUMBER() OVER (ORDER BY C.name) AS [Row]
FROM syscolumns C
INNER JOIN systypes T ON C.xusertype = T.xusertype 
left JOIN sys.extended_properties ETP   ON  ETP.major_id = c.id AND ETP.minor_id = C.colid AND ETP.name ='MS_Description' 
left join syscomments CM on C.cdefault=CM.id
WHERE C.id = object_id('tms_order');