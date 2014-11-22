CREATE TABLE [dbo].[APILogs]
(
[Id] [bigint] NOT NULL IDENTITY(1, 1),
[ClientIP] [nvarchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[RequestTime] [datetime] NOT NULL,
[CorrelationId] [nvarchar] (200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[RequestInfo] [nvarchar] (400) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Response] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Header] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RequestBody] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ResponseStatusCode] [nvarchar] (400) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ApplicationName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[APILogs] ADD CONSTRAINT [PK_APILogs] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO

CREATE PROCEDURE LogApiCall
@ApplicationName NVARCHAR(max),
@ClientIP NVARCHAR(100),
 @CorrelationId [nvarchar] (200),
                    @Header [nvarchar] (max), 
                    @Id [bigint],
                     @RequestBody [nvarchar] (max), 
                    @RequestInfo [nvarchar] (400), 
                    @RequestTime [datetime], @Response [nvarchar] (max), 
                    @ResponseStatusCode  [nvarchar] (400)
AS
BEGIN
	DECLARE @Correlatn NVARCHAR(200)
	
	SELECT @Correlatn = CorrelationId FROM dbo.APILogs WHERE CorrelationId = @CorrelationId OR Id = @Id
	
	IF(@Correlatn IS NOT NULL)
	UPDATE dbo.APILogs SET ApplicationName = @ApplicationName, 
	ClientIP=@ClientIP,
	 CorrelationId= @CorrelationId, Header=@Header, RequestBody=@RequestBody, 
	 RequestInfo=@RequestInfo, RequestTime=@RequestTime, Response=@Response, ResponseStatusCode=@ResponseStatusCode
	 
	WHERE @CorrelationId = @Correlatn
	ELSE
	INSERT INTO dbo.APILogs
	        ( ClientIP ,
	          RequestTime ,
	          CorrelationId ,
	          RequestInfo ,
	          Response ,
	          Header ,
	          RequestBody ,
	          ResponseStatusCode ,
	          ApplicationName
	        )
	        
	VALUES  ( 
	@ClientIP ,
	          @RequestTime ,
	          @CorrelationId ,
	          @RequestInfo ,
	          @Response ,
	          @Header ,
	          @RequestBody ,
	          @ResponseStatusCode ,
	          @ApplicationName
	        )
	
END