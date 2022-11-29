insert into dbo.trades
(    [OrderId]
      ,[ImportDate]
      ,[OrderType]
      ,[Symbol]
      ,[Side]
      ,[Price]
      ,[Qty]
      ,[Commission]
      ,[RealizedPnl]
      ,[TotalPnl]
      , [EquityCurve]
)


VALUES(21653293432, '11/19/2022', 'Close', 'MATICUSDT', 'SELL', 0.87486, 14169, -4.95854896,74.96833634, 70.00978738, -35814.45)

-- insert into dbo.trades
-- (    [OrderId]
--       ,[ImportDate]
--       ,[OrderType]
--       ,[Symbol]
--       ,[Side]
--       ,[Price]
--       ,[Qty]
--       ,[Commission]
--       ,[RealizedPnl]
--       ,[TotalPnl]
--       ,[EquityCurve])

-- VALUES(21653293432, '11/19/2022', 'Close', 'MATICUSDT', 'SELL', 0.87486, 14169, -4.95854896, 74.96833634, 70.00978738, -35,814.45)