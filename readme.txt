1.marketms.sql还原到mysql
2.如果要用支付宝支付功能，修改【F2F_PAY】->【app_code】->【Config.cs】文件中的相关配置，具体可参考https://openhome.alipay.com/platform/appDaily.htm?tab=account
3.【MarketMS】->【UI】->【FrmPayWithAlipay.cs】中修改点击支付宝支付页面跳转地址，端口可能要改下，具体看自己web服务，可右键aspx在浏览器中查看具体地址
4.【MarketMS】->【BaseClass】->【DBConn.cs】中修改数据库连接
5.【MarketMS】->【UI】->【UFrmSyt.cs】中第512行代码，修改二维码解析地址
6.【MarketMS.php】中第56行、第98行修改数据库连接