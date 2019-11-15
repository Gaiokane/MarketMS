/*
 Navicat Premium Data Transfer

 Source Server         : MarketMS
 Source Server Type    : MySQL
 Source Server Version : 50725
 Source Host           : localhost
 Source Schema         : marketms

 Target Server Type    : MySQL
 Target Server Version : 50725
 File Encoding         : 65001

 Date: 15/11/2019 20:33:59
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tb_employee
-- ----------------------------
DROP TABLE IF EXISTS `tb_employee`;
CREATE TABLE `tb_employee`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EID` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工id',
  `EName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工姓名',
  `ESex` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工性别',
  `EAge` int(20) NOT NULL COMMENT '员工年龄',
  `EPID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工职位id',
  `ETel` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工电话',
  `EPasswd` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登陆密码',
  `EAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工地址',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '员工信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_employee
-- ----------------------------
INSERT INTO `tb_employee` VALUES (1, 'admin', 'Gaiokane', '男', 22, '1', '00000000000', 'qqq', '111');
INSERT INTO `tb_employee` VALUES (2, 'q', 'qk', '男', 23, '2', '13776242820', 'q', 'zjg');
INSERT INTO `tb_employee` VALUES (3, 'xtgly', '我是系统管理员', '男', 11, '1', '11111111111', 'xtgly', '1');
INSERT INTO `tb_employee` VALUES (4, 'dz', '我是店长', '男', 12, '2', '22222222222', 'dz', '2');
INSERT INTO `tb_employee` VALUES (5, 'rsb', '我是人事部', '男', 13, '3', '33333333333', 'rsb', '3');
INSERT INTO `tb_employee` VALUES (6, 'xsb', '我是销售部', '女', 14, '4', '44444444444', 'xsb', '4');
INSERT INTO `tb_employee` VALUES (7, 'kcglb', '我是库存管理部', '女', 15, '5', '55555555555', 'kcglb', '5');
INSERT INTO `tb_employee` VALUES (8, 'syy1', '我是收银员1', '男', 16, '6', '66666666666', 'syy1', '6');
INSERT INTO `tb_employee` VALUES (9, 'syy2', '我是收银员2', '女', 17, '6', '77777777777', 'syy2', '7');
INSERT INTO `tb_employee` VALUES (10, 'syy3', '我是收银员3', '女', 18, '6', '88888888888', 'syy3', '8');

-- ----------------------------
-- Table structure for tb_employeeposition
-- ----------------------------
DROP TABLE IF EXISTS `tb_employeeposition`;
CREATE TABLE `tb_employeeposition`  (
  `EPID` int(20) NOT NULL AUTO_INCREMENT COMMENT '职位id',
  `EPName` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '职位名称',
  `EPCount` int(11) NULL DEFAULT NULL COMMENT '职位人数',
  PRIMARY KEY (`EPID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 7 CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '员工职位表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_employeeposition
-- ----------------------------
INSERT INTO `tb_employeeposition` VALUES (1, '系统管理员', 2);
INSERT INTO `tb_employeeposition` VALUES (2, '店长', 2);
INSERT INTO `tb_employeeposition` VALUES (3, '人事部', 1);
INSERT INTO `tb_employeeposition` VALUES (4, '销售部', 1);
INSERT INTO `tb_employeeposition` VALUES (5, '库存管理部', 1);
INSERT INTO `tb_employeeposition` VALUES (6, '收银员', 3);

-- ----------------------------
-- Table structure for tb_goods
-- ----------------------------
DROP TABLE IF EXISTS `tb_goods`;
CREATE TABLE `tb_goods`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `GID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品id',
  `GName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `GCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品分类id',
  `GPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品售价',
  `GBid` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品进价',
  `GAmount` int(20) NULL DEFAULT NULL COMMENT '商品库存',
  `GMinimumInventory` int(20) NULL DEFAULT NULL COMMENT '商品最小库存',
  `GUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品单位',
  `GShelfLife` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品有效期',
  `GProductionDate` datetime(0) NULL DEFAULT NULL COMMENT '商品生产日期',
  `GSupplier` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品供应商',
  `GNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品说明/备注',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 39 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '商品信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_goods
-- ----------------------------
INSERT INTO `tb_goods` VALUES (13, 'G205047324', '蒙牛纯牛奶', '1', 42.00, 33.00, 18, 10, '箱', '180天', '2018-04-03 00:00:00', '内蒙古蒙牛乳业（集团）股份有限公司', '');
INSERT INTO `tb_goods` VALUES (14, 'G205233827', '伊利安慕希原味酸奶', '1', 6.50, 38.00, 6, 5, '箱', '6个月', '2018-04-11 00:00:00', '内蒙古伊利实业集团股份有限公司', '');
INSERT INTO `tb_goods` VALUES (15, 'G205421245', '港荣奶香蒸蛋糕', '1', 38.20, 26.00, 10, 15, '箱', '35天', '2018-04-11 00:00:00', '港荣食品发展有限公司', '');
INSERT INTO `tb_goods` VALUES (16, 'G205633524', '乐事薯片礼盒', '1', 16.90, 48.00, 29, 20, '箱', '9个月', '2018-04-11 00:00:00', '百事公司', '');
INSERT INTO `tb_goods` VALUES (17, 'G205832023', '百事巴厘岛蓝色可乐', '1', 12.90, 8.00, 44, 30, '瓶', '12个月', '2018-04-11 00:00:00', '百事公司', '');
INSERT INTO `tb_goods` VALUES (18, 'G205904834', '金龙鱼玉米油', '2', 39.90, 31.00, 9, 5, '桶', '18个月', '2018-04-07 00:00:00', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `tb_goods` VALUES (19, 'G210114645', '鲁花5S一级花生油', '2', 119.90, 93.00, 8, 5, '桶', '18个月', '2018-04-11 00:00:00', '山东鲁花集团有限公司', '');
INSERT INTO `tb_goods` VALUES (20, 'G210854825', '金龙鱼盘锦大米', '2', 16.90, 48.00, 20, 10, '袋', '18个月', '2018-04-11 00:00:00', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `tb_goods` VALUES (21, 'G210927823', '清扬男士去屑洗发露', '3', 10.80, 44.00, 18, 5, '瓶', '36个月', '2018-04-11 00:00:00', '清扬技术中心', '');
INSERT INTO `tb_goods` VALUES (22, 'G211041035', '黑人牙膏', '3', 14.50, 9.00, 4, 3, '支', '36个月', '2018-04-11 00:00:00', '好来化工（中山）有限公司', '');
INSERT INTO `tb_goods` VALUES (23, 'G211152026', '九阳电热水壶', '7', 26.00, 54.00, 5, 8, '台', '个月', '2018-04-11 00:00:00', '九阳股份有限公司', '');
INSERT INTO `tb_goods` VALUES (24, 'G211318791', '美的WK2102电磁炉', '7', 209.00, 188.00, 4, 3, '台', '个月', '2018-04-11 00:00:00', '美的集团', '');
INSERT INTO `tb_goods` VALUES (25, 'G214612828', '清风抽纸原木金装', '8', 19.90, 55.00, 7, 5, '包', '36个月', '2018-04-11 00:00:00', '金红叶纸业集团有限公司', '');
INSERT INTO `tb_goods` VALUES (26, 'G214747923', '妙洁点断式垃圾袋', '8', 8.90, 6.00, 8, 7, '只', '48个月', '2018-03-16 00:00:00', '脱普（中国）企业集团', '');
INSERT INTO `tb_goods` VALUES (27, 'G214856823', '墨西哥牛油果6个', '10', 39.90, 30.00, 19, 10, '只', '5天', '2018-04-11 00:00:00', 'SunMoon', '');
INSERT INTO `tb_goods` VALUES (28, 'G215032340', '四川黄果柑', '10', 5.98, 3.50, 20, 8, '斤', '20天', '2018-04-11 00:00:00', '四川雅安', '');
INSERT INTO `tb_goods` VALUES (29, 'G215310892', '海南小台农芒果', '10', 9.90, 6.00, 14, 10, '只', '10天', '2018-04-11 00:00:00', '海南芒果', '');
INSERT INTO `tb_goods` VALUES (30, 'G215413825', '恒都巴西牛腱子', '10', 29.95, 21.00, 30, 15, '斤', '12个月', '2018-04-11 00:00:00', '恒都巴西', '');
INSERT INTO `tb_goods` VALUES (31, 'G215548456', '恒都巴西牛腩块', '10', 26.95, 18.00, 30, 15, '斤', '12个月', '2018-04-11 00:00:00', '恒都巴西', '');
INSERT INTO `tb_goods` VALUES (32, 'G215609249', '原膳南美白虾仁(中)', '10', 19.90, 16.00, 12, 5, '包', '12个月', '2018-04-11 00:00:00', '越南原膳', '');
INSERT INTO `tb_goods` VALUES (33, 'G215714325', '獐子岛蒜蓉粉丝扇贝', '10', 4.25, 38.00, 22, 12, '斤', '12个月', '2018-04-11 00:00:00', '獐子岛', '');
INSERT INTO `tb_goods` VALUES (34, 'G215931893', '西红柿', '10', 7.90, 4.00, 30, 10, '斤', '5天', '2018-04-11 00:00:00', '山东寿光西红柿', '');
INSERT INTO `tb_goods` VALUES (35, 'G220047925', '山东紫薯', '10', 6.50, 4.00, 15, 5, '斤', '3天', '2018-04-11 00:00:00', '山东紫薯', '');
INSERT INTO `tb_goods` VALUES (36, 'G220145243', '菜园土豆', '10', 3.90, 1.20, 50, 20, '斤', '12个月', '2018-04-11 00:00:00', '山东菜园土豆', '');
INSERT INTO `tb_goods` VALUES (37, 'G220256873', '精选小青菜', '10', 3.80, 2.60, 10, 5, '斤', '3天', '2018-04-11 00:00:00', '青浦精选', '');
INSERT INTO `tb_goods` VALUES (38, '1', '1', '1', 1.00, 1.00, 1, 1, '1', '1', '2018-01-01 11:11:11', '1', '1');

-- ----------------------------
-- Table structure for tb_goodscategory
-- ----------------------------
DROP TABLE IF EXISTS `tb_goodscategory`;
CREATE TABLE `tb_goodscategory`  (
  `GCID` int(11) NOT NULL AUTO_INCREMENT COMMENT '商品分类id',
  `GCName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品分类名称',
  PRIMARY KEY (`GCID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 11 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '商品类别表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_goodscategory
-- ----------------------------
INSERT INTO `tb_goodscategory` VALUES (1, '食品饮料');
INSERT INTO `tb_goodscategory` VALUES (2, '粮油副食');
INSERT INTO `tb_goodscategory` VALUES (3, '美容洗护');
INSERT INTO `tb_goodscategory` VALUES (7, '家电');
INSERT INTO `tb_goodscategory` VALUES (8, '家庭清洁');
INSERT INTO `tb_goodscategory` VALUES (10, '生鲜水果');

-- ----------------------------
-- Table structure for tb_goodssupplier
-- ----------------------------
DROP TABLE IF EXISTS `tb_goodssupplier`;
CREATE TABLE `tb_goodssupplier`  (
  `GSID` int(11) NOT NULL AUTO_INCREMENT COMMENT '供应商id',
  `GSName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '供应商名称',
  `GSPName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商联系人姓名',
  `GSTel` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商联系人电话',
  `GSAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商地址',
  `GSNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商备注',
  PRIMARY KEY (`GSID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 26 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '供应商信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_goodssupplier
-- ----------------------------
INSERT INTO `tb_goodssupplier` VALUES (3, '内蒙古蒙牛乳业（集团）股份有限公司', '内先生', '13222222222', '内蒙古', '');
INSERT INTO `tb_goodssupplier` VALUES (4, '内蒙古伊利实业集团股份有限公司', '伊女士', '12342134231', '内蒙古', '');
INSERT INTO `tb_goodssupplier` VALUES (5, '港荣食品发展有限公司', '港女士', '13444444444', '上海', '');
INSERT INTO `tb_goodssupplier` VALUES (6, '百事公司', '百先生', '13555555555', '上海', '');
INSERT INTO `tb_goodssupplier` VALUES (7, '新加坡郭兄弟粮油私人有限公司', '郭先生', '13666666666', '新加坡', '');
INSERT INTO `tb_goodssupplier` VALUES (8, '山东鲁花集团有限公司', '鲁先生', '15111111111', '山东', '');
INSERT INTO `tb_goodssupplier` VALUES (9, '清扬技术中心', '1清女士', '11111111111', '北京', '');
INSERT INTO `tb_goodssupplier` VALUES (10, '好来化工（中山）有限公司', '好先生', '13333333333', '中山', '');
INSERT INTO `tb_goodssupplier` VALUES (11, '九阳股份有限公司', '九先生', '14533333333', '北京', '');
INSERT INTO `tb_goodssupplier` VALUES (12, '美的集团', '美女士', '18888888888', '上海', '');
INSERT INTO `tb_goodssupplier` VALUES (13, '金红叶纸业集团有限公司', '金先生', '18222222222', '上海', '');
INSERT INTO `tb_goodssupplier` VALUES (14, '脱普（中国）企业集团', '朴先生', '12333333333', '中国', '');
INSERT INTO `tb_goodssupplier` VALUES (15, 'SunMoon', 'SunMoon先生', '666666', '墨西哥', '');
INSERT INTO `tb_goodssupplier` VALUES (16, '四川雅安', '雅女士', '11113333333', '四川', '');
INSERT INTO `tb_goodssupplier` VALUES (17, '海南芒果', '芒女士', '2222221111', '海南', '');
INSERT INTO `tb_goodssupplier` VALUES (18, '恒都巴西', '恒女士', '41133333', '巴西', '');
INSERT INTO `tb_goodssupplier` VALUES (19, '越南原膳', '原先生', '4213123123', '越南', '');
INSERT INTO `tb_goodssupplier` VALUES (20, '獐子岛', '獐先生', '5634524', '辽宁大连', '');
INSERT INTO `tb_goodssupplier` VALUES (21, '山东寿光西红柿', '山先生', '123111123', '山东寿光', '');
INSERT INTO `tb_goodssupplier` VALUES (22, '山东紫薯', '董先生', '233534', '山东临沂', '');
INSERT INTO `tb_goodssupplier` VALUES (23, '山东菜园土豆', '蔡先生', '123211245', '山东', '');
INSERT INTO `tb_goodssupplier` VALUES (24, '青浦精选', '清女士', '57214124', '上海青浦', '');
INSERT INTO `tb_goodssupplier` VALUES (25, '1', NULL, '11111111111', NULL, NULL);

-- ----------------------------
-- Table structure for tb_loginlog
-- ----------------------------
DROP TABLE IF EXISTS `tb_loginlog`;
CREATE TABLE `tb_loginlog`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `LoginUserName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录用户名',
  `LoginTime` datetime(0) NOT NULL COMMENT '登录时间',
  `LoginPublicIP` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录内网ip',
  `LoginLocalIP` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '登录外网ip',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 24 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '登录日志' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_loginlog
-- ----------------------------
INSERT INTO `tb_loginlog` VALUES (1, 'q', '2018-04-15 20:18:58', '192.168.110.1', '36.149.133.129');
INSERT INTO `tb_loginlog` VALUES (2, 'q', '2018-04-22 15:39:15', '192.168.110.1', '36.149.5.156');
INSERT INTO `tb_loginlog` VALUES (3, 'syy1', '2018-04-22 17:03:42', '192.168.110.1', '36.149.5.156');
INSERT INTO `tb_loginlog` VALUES (4, 'q', '2018-04-22 17:04:26', '192.168.110.1', '36.149.5.156');
INSERT INTO `tb_loginlog` VALUES (5, 'q', '2018-05-02 20:34:34', '192.168.110.1', '36.149.133.247');
INSERT INTO `tb_loginlog` VALUES (6, 'q', '2018-05-15 20:59:39', '192.168.110.1', '36.149.133.166');
INSERT INTO `tb_loginlog` VALUES (7, 'syy1', '2018-05-17 20:04:07', '192.168.110.1', '36.149.133.233');
INSERT INTO `tb_loginlog` VALUES (8, 'q', '2018-05-17 20:15:48', '192.168.110.1', '36.149.133.233');
INSERT INTO `tb_loginlog` VALUES (9, 'q', '2018-07-25 21:32:08', '192.168.170.1', 'YPE html>\r\n');
INSERT INTO `tb_loginlog` VALUES (10, 'q', '2018-07-25 21:42:49', '192.168.170.1', 'YPE html>\r\n');
INSERT INTO `tb_loginlog` VALUES (11, 'q', '2018-07-25 21:44:15', '192.168.170.1', 'YPE html>\r\n');
INSERT INTO `tb_loginlog` VALUES (12, 'q', '2018-07-26 21:17:27', '192.168.170.1', '36.149.133.119');
INSERT INTO `tb_loginlog` VALUES (13, 'q', '2018-07-26 22:34:47', '192.168.170.1', '36.149.133.119');
INSERT INTO `tb_loginlog` VALUES (14, 'q', '2018-07-26 22:35:18', '192.168.170.1', '36.149.133.119');
INSERT INTO `tb_loginlog` VALUES (15, 'q', '2018-07-26 22:50:58', '192.168.170.1', '36.149.133.119');
INSERT INTO `tb_loginlog` VALUES (16, 'q', '2018-07-26 23:03:40', '192.168.170.1', '36.149.133.119');
INSERT INTO `tb_loginlog` VALUES (17, 'q', '2018-07-28 12:20:07', '192.168.170.1', '36.149.5.156');
INSERT INTO `tb_loginlog` VALUES (18, 'q', '2018-07-28 23:54:05', '192.168.170.1', '36.149.5.156');
INSERT INTO `tb_loginlog` VALUES (19, 'q', '2018-07-29 15:50:07', '192.168.170.1', '36.149.5.78');
INSERT INTO `tb_loginlog` VALUES (20, 'q', '2018-07-29 15:55:22', '192.168.170.1', '36.149.5.78');
INSERT INTO `tb_loginlog` VALUES (21, 'q', '2018-07-29 17:02:16', '192.168.170.1', '36.149.5.78');
INSERT INTO `tb_loginlog` VALUES (22, 'q', '2018-07-31 10:41:22', '192.168.1.127', '180.106.155.114');
INSERT INTO `tb_loginlog` VALUES (23, 'q', '2018-08-01 19:35:12', '169.254.224.192', '36.149.133.99');

-- ----------------------------
-- Table structure for tb_order
-- ----------------------------
DROP TABLE IF EXISTS `tb_order`;
CREATE TABLE `tb_order`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '订单编号',
  `OGID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品编号',
  `OGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `OGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品分类名称',
  `OGAmount` int(20) NOT NULL COMMENT '商品数量',
  `OGPrice` decimal(18, 2) NOT NULL COMMENT '商品售价',
  `OGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品单位',
  `OGSum` decimal(18, 2) NOT NULL COMMENT '商品总价',
  `OEID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '员工id',
  `OPaymentMethod` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单支付方式',
  `IsReturn` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '是否退货',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 33 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '订单信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_order
-- ----------------------------
INSERT INTO `tb_order` VALUES (18, 'MMS20180411104303', 'G20180411085233', '伊利安慕希原味酸奶', '食品饮料', 2, 50.00, '箱', 100.00, 'xsy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (19, 'MMS20180411104303', 'G20180411085832', '百事巴厘岛蓝色可乐', '食品饮料', 1, 13.00, '瓶', 13.00, 'xsy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (20, 'MMS20180411104303', 'G20180411085633', '乐事薯片礼盒', '食品饮料', 1, 60.00, '箱', 60.00, 'xsy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (21, 'MMS20180411104303', 'G20180411094856', '墨西哥牛油果6个', '生鲜水果', 1, 40.00, '只', 40.00, 'xsy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (22, 'MMS20180411104303', 'G20180411095714', '獐子岛蒜蓉粉丝扇贝', '生鲜水果', 1, 47.00, '斤', 47.00, 'xsy1', '支付宝', '是');
INSERT INTO `tb_order` VALUES (23, 'MMS20180411104754', 'G20180411091318', '美的WK2102电磁炉', '家电', 1, 209.00, '台', 209.00, 'xsy1', '现金', '否');
INSERT INTO `tb_order` VALUES (24, 'MMS20180411104754', 'G20180411091041', '黑人牙膏', '美容洗护', 2, 14.00, '支', 28.00, 'xsy1', '现金', '否');
INSERT INTO `tb_order` VALUES (25, 'MMS20180411104754', 'G20180411085904', '金龙鱼玉米油', '粮油副食', 1, 40.00, '桶', 40.00, 'xsy1', '现金', '否');
INSERT INTO `tb_order` VALUES (26, 'MMS20180411104754', 'G20180411094747', '妙洁点断式垃圾袋', '家庭清洁', 2, 9.00, '只', 18.00, 'xsy1', '现金', '否');
INSERT INTO `tb_order` VALUES (27, 'MMS20180411104754', 'G20180411095310', '海南小台农芒果', '生鲜水果', 1, 10.00, '只', 10.00, 'xsy1', '现金', '否');
INSERT INTO `tb_order` VALUES (28, 'MMS20180422153919', 'G205047324', '蒙牛纯牛奶', '食品饮料', 2, 41.00, '箱', 82.00, 'q', '现金', '否');
INSERT INTO `tb_order` VALUES (29, 'MMS20180517200415', 'G211152026', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, 'syy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (30, 'MMS20180517200415', 'G215310892', '海南小台农芒果', '生鲜水果', 2, 10.00, '只', 20.00, 'syy1', '支付宝', '否');
INSERT INTO `tb_order` VALUES (31, 'MMS20180517201551', 'G211152026', '九阳电热水壶', '家电', 1, 69.00, '台', 69.00, 'q', '支付宝', '否');
INSERT INTO `tb_order` VALUES (32, 'MMS20180517201551', 'G215310892', '海南小台农芒果', '生鲜水果', 3, 10.00, '只', 30.00, 'q', '支付宝', '否');

-- ----------------------------
-- Table structure for tb_purchaseorder
-- ----------------------------
DROP TABLE IF EXISTS `tb_purchaseorder`;
CREATE TABLE `tb_purchaseorder`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `POID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '进货单编号',
  `PODate` date NULL DEFAULT NULL COMMENT '进货日期',
  `POGID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品编号',
  `POGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL COMMENT '商品名称',
  `POGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品类别',
  `POGPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品售价',
  `POGBid` decimal(18, 2) NULL DEFAULT NULL COMMENT '商品进价',
  `POAmount` int(20) NULL DEFAULT NULL COMMENT '进货数量',
  `POGMinimumInventory` int(20) NULL DEFAULT NULL COMMENT '商品最小库存',
  `POGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品单位',
  `POGShelfLife` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '商品保质期',
  `POGProductionDate` date NULL DEFAULT NULL COMMENT '商品生产日期',
  `POGSupplier` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '供应商',
  `POGNotes` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '备注',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 44 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '进货表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_purchaseorder
-- ----------------------------
INSERT INTO `tb_purchaseorder` VALUES (19, 'PO20180411101335', '2018-04-11', 'G20180411085047', '蒙牛纯牛奶', '1', 41.00, 33.00, 20, 10, '箱', '180天', '2018-04-03', '内蒙古蒙牛乳业（集团）股份有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (20, 'PO20180411101426', '2018-04-11', 'G20180411085233', '伊利安慕希原味酸奶', '1', 49.50, 38.00, 8, 5, '箱', '6个月', '2018-04-11', '内蒙古伊利实业集团股份有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (21, 'PO20180411101453', '2018-04-11', 'G20180411085421', '港荣奶香蒸蛋糕', '1', 38.20, 26.00, 10, 15, '箱', '35天', '2018-04-11', '港荣食品发展有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (22, 'PO20180411101525', '2018-04-11', 'G20180411085633', '乐事薯片礼盒', '1', 59.90, 48.00, 30, 20, '箱', '9个月', '2018-04-11', '百事公司', '');
INSERT INTO `tb_purchaseorder` VALUES (23, 'PO20180411101610', '2018-04-11', 'G20180411085832', '百事巴厘岛蓝色可乐', '1', 12.90, 8.00, 45, 30, '瓶', '12个月', '2018-04-11', '百事公司', '');
INSERT INTO `tb_purchaseorder` VALUES (24, 'PO20180411101649', '2018-04-11', 'G20180411085904', '金龙鱼玉米油', '2', 39.90, 31.00, 10, 5, '桶', '18个月', '2018-04-07', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (25, 'PO20180411101752', '2018-04-11', 'G20180411090114', '鲁花5S一级花生油', '2', 119.90, 93.00, 8, 5, '桶', '18个月', '2018-04-11', '山东鲁花集团有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (26, 'PO20180411101855', '2018-04-11', 'G20180411090854', '金龙鱼盘锦大米', '2', 59.90, 48.00, 20, 10, '袋', '18个月', '2018-04-11', '新加坡郭兄弟粮油私人有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (27, 'PO20180411102040', '2018-04-11', 'G20180411090927', '清扬男士去屑洗发露', '3', 53.80, 44.00, 6, 5, '瓶', '36个月', '2018-04-11', '清扬技术中心', '');
INSERT INTO `tb_purchaseorder` VALUES (28, 'PO20180411102156', '2018-04-11', 'G20180411091041', '黑人牙膏', '3', 14.50, 9.00, 6, 3, '支', '36个月', '2018-04-11', '好来化工（中山）有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (29, 'PO20180411102319', '2018-04-11', 'G20180411091152', '九阳电热水壶', '7', 69.00, 54.00, 7, 8, '台', '个月', '2018-04-11', '九阳股份有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (30, 'PO20180411102359', '2018-04-11', 'G20180411091318', '美的WK2102电磁炉', '7', 209.00, 188.00, 5, 3, '台', '个月', '2018-04-11', '美的集团', '');
INSERT INTO `tb_purchaseorder` VALUES (31, 'PO20180411102440', '2018-04-11', 'G20180411094612', '清风抽纸原木金装', '8', 62.90, 55.00, 7, 5, '包', '36个月', '2018-04-11', '金红叶纸业集团有限公司', '');
INSERT INTO `tb_purchaseorder` VALUES (32, 'PO20180411102521', '2018-04-11', 'G20180411094747', '妙洁点断式垃圾袋', '8', 8.90, 6.00, 10, 7, '只', '48个月', '2018-03-16', '脱普（中国）企业集团', '');
INSERT INTO `tb_purchaseorder` VALUES (33, 'PO20180411102834', '2018-04-11', 'G20180411094856', '墨西哥牛油果6个', '10', 39.90, 30.00, 20, 10, '只', '5天', '2018-04-11', 'SunMoon', '');
INSERT INTO `tb_purchaseorder` VALUES (34, 'PO20180411102949', '2018-04-11', 'G20180411095032', '四川黄果柑', '10', 5.98, 3.50, 20, 8, '斤', '20天', '2018-04-11', '四川雅安', '');
INSERT INTO `tb_purchaseorder` VALUES (35, 'PO20180411103029', '2018-04-11', 'G20180411095310', '海南小台农芒果', '10', 9.90, 6.00, 20, 10, '只', '10天', '2018-04-11', '海南芒果', '');
INSERT INTO `tb_purchaseorder` VALUES (36, 'PO20180411103103', '2018-04-11', 'G20180411095413', '恒都巴西牛腱子', '10', 29.95, 21.00, 30, 15, '斤', '12个月', '2018-04-11', '恒都巴西', '');
INSERT INTO `tb_purchaseorder` VALUES (37, 'PO20180411103140', '2018-04-11', 'G20180411095548', '恒都巴西牛腩块', '10', 26.95, 18.00, 30, 15, '斤', '12个月', '2018-04-11', '恒都巴西', '');
INSERT INTO `tb_purchaseorder` VALUES (38, 'PO20180411103215', '2018-04-11', 'G20180411095609', '原膳南美白虾仁(中)', '10', 19.90, 16.00, 12, 5, '包', '12个月', '2018-04-11', '越南原膳', '');
INSERT INTO `tb_purchaseorder` VALUES (39, 'PO20180411103246', '2018-04-11', 'G20180411095714', '獐子岛蒜蓉粉丝扇贝', '10', 47.25, 38.00, 22, 12, '斤', '12个月', '2018-04-11', '獐子岛', '');
INSERT INTO `tb_purchaseorder` VALUES (40, 'PO20180411103418', '2018-04-11', 'G20180411095931', '西红柿', '10', 7.90, 4.00, 30, 10, '斤', '5天', '2018-04-11', '山东寿光西红柿', '');
INSERT INTO `tb_purchaseorder` VALUES (41, 'PO20180411103453', '2018-04-11', 'G20180411100047', '山东紫薯', '10', 6.50, 4.00, 15, 5, '斤', '3天', '2018-04-11', '山东紫薯', '');
INSERT INTO `tb_purchaseorder` VALUES (42, 'PO20180411103536', '2018-04-11', 'G20180411100145', '菜园土豆', '10', 3.90, 1.20, 50, 20, '斤', '12个月', '2018-04-11', '山东菜园土豆', '');
INSERT INTO `tb_purchaseorder` VALUES (43, 'PO20180411103613', '2018-04-11', 'G20180411100256', '精选小青菜', '10', 3.80, 2.60, 10, 5, '斤', '3天', '2018-04-11', '青浦精选', '');

-- ----------------------------
-- Table structure for tb_returnorder
-- ----------------------------
DROP TABLE IF EXISTS `tb_returnorder`;
CREATE TABLE `tb_returnorder`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `OID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单编号',
  `ROGName` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品名',
  `ROGCID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品类别',
  `ROGAomunt` int(20) NULL DEFAULT NULL COMMENT '退货商品数量',
  `ROGPrice` decimal(18, 2) NULL DEFAULT NULL COMMENT '退货商品售价',
  `ROGUnit` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货商品单位',
  `ROGSum` decimal(18, 2) NULL DEFAULT NULL COMMENT '退货商品总价',
  `ROPaymentMethod` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '订单支付方式',
  `ROReason` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货原因',
  `ROID` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL COMMENT '退货id',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 13 CHARACTER SET = utf8 COLLATE = utf8_unicode_ci COMMENT = '退货信息表' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_returnorder
-- ----------------------------
INSERT INTO `tb_returnorder` VALUES (12, 'MMS20180411104303', '獐子岛蒜蓉粉丝扇贝', '生鲜水果', 1, 47.00, '斤', 47.00, '支付宝', '1', 'RWA20180411104949');

SET FOREIGN_KEY_CHECKS = 1;
