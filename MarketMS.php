<html>
<meta name="viewport" content="width=device-width,initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no"/>
<head>
	<title>购物单详细信息</title>
	
	<style type="text/css">
		.table{
			width: 100%;
			border-collapse:collapse; 
			border-spacing:0; 
		}
		.fixedThead{
			display: block;
			width: 100%;
		}
		.scrollTbody{
			display: block;
			height: 262px;
			overflow: auto;
			width: 100%;
		}
		.table td,.table th {
			width: 200px;
			border-bottom: none;
			border-left: none;
			border-right: 1px solid #CCC;
			border-top: 1px solid #DDD;
			padding: 2px 3px 3px 4px
		}
		.table tr{
			border-left: 1px solid #EB8;
			border-bottom: 1px solid #B74;
		}
		thead.fixedThead tr th:last-child {
			color:#FF0000;
			width: 50%;
		}
	</style>
	
</head>
<body>
	<table style='text-align:left;' border='1' frame='void' rules='all'>
		<tr>
			<th>商品编号</th>
			<th>商品名称</th>
			<th>类别</th>
			<th>数量</th>
			<th>单价</th>
			<th>单位</th>
			<th>总价</th>
		</tr>
	
		<?php
			echo "您的订单编号是：".$_SERVER["QUERY_STRING"];
			
			$con=mysqli_connect("localhost","qk","11111","marketms","3306");
			if (mysqli_connect_errno($con))
			{
				echo "数据库连接失败：" . mysqli_connect_error();
			}

			$sql = "select OGID, OGName, OGCID, OGAmount, OGPrice, OGUnit, OGSum from tb_Order where OID='".$_SERVER["QUERY_STRING"]."'";

			if ($result=mysqli_query($con,$sql))
			{
				// 返回记录数
				$rowcount=mysqli_num_rows($result);

				//循环遍历出数据表中的数据
				for($i=0;$i<$rowcount;$i++){
					$sql_arr = mysqli_fetch_assoc($result);
					$ogid = $sql_arr["OGID"];
					$ogname = $sql_arr["OGName"];
					$ogcid = $sql_arr["OGCID"];
					$ogamount = $sql_arr["OGAmount"];
					$ogprice = $sql_arr["OGPrice"];
					$ogunit = $sql_arr["OGUnit"];
					$ogsum = $sql_arr["OGSum"];
					$sum = $sum + $sql_arr["OGSum"];
					echo "<tr><td>$ogid</td><td>$ogname</td><td>$ogcid</td><td>$ogamount</td><td>$ogprice</td><td>$ogunit</td><td>$ogsum</td></tr>";
				}
				echo "<tr><th>合计<th><td></td><td></td><td></td><td></td><th>$sum</th></tr>";
			}
			mysqli_close($con);
		?>
	</table>
	
	<br>
	<div class="text" style="text-align:center; width:100%">超市商品</div>
	
	<table class="table">
		<thead class="fixedThead">
			<tr><th>商品名称</th><th>价格</th></tr>
		</thead>
		<tbody class="scrollTbody">
			
			<?php
                        $con=mysqli_connect("localhost","qk","11111","marketms","3306");
			if (mysqli_connect_errno($con))
			{
				echo "数据库连接失败：" . mysqli_connect_error();
			}

			$sql = "select GName, GPrice, GUnit from tb_Goods where GAmount > 0";

			if ($result=mysqli_query($con,$sql))
			{
				// 返回记录数
				$rowcount=mysqli_num_rows($result);

				//循环遍历出数据表中的数据
				for($i=0;$i<$rowcount;$i++){
					$sql_arr = mysqli_fetch_assoc($result);
					$gname = $sql_arr["GName"];
					$gprice = $sql_arr["GPrice"];
					$gunit = $sql_arr["GUnit"];
					echo "<tr><td>$gname</td><td>$gprice/$gunit</td></tr>";
				}
			}
			mysqli_close($con);
		?>
		</tbody>
	</table>
	
</body>
</html>
