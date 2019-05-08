
### homework 1


1. 画出Base58Check的解码过程流程图

2. 编码实现，梅克尔树根节点hash值计算。假设叶子节点为三笔交易，字节分为为: 0x0000, 0x1111, 0x2222

3. 画图描述一笔UTXO的流通。Tom最开始有8个NEO，转账给Alice 5个Neo，Alice再将其中的1个NEO转给Lily，1个给了Tom。



### homework 2



1. 画图描述NEO的经济模型

2. 尝试画一幅NEO的一笔交易的完整流程



### homework 3

1. 尝试画一幅，私钥-> 公钥-> 脚本-> 地址 的转换图

2. 交易所会有大量的NEO账户地址，我们推荐交易所使用SQLite 还是NEP6 钱包？请说明理由



### homework 4

1. 描述节点之间的握手协议

2. 对比以太坊的Gossip协议的优劣



### homework 5

1. 描述交易的结构，生命周期


2. 描述区块的结构，与生命周期


3. 描述NEO是如何指定当前共识节点

4. 对比 UTXO类型的交易，与合约交易的优劣



### homework 6

1. 描述NEO的共识过程，如何出新区块


2. 描述NEO的投票规则，如何确定共识节点数，和具体的共识节点


### homework 7

1. 理解智能合约的生命周期

2. 尝试本地发送一笔 Invocation的NEP5资产转账，并计算其Gas消耗，并再区块链浏览器上查看其Script字段，并翻译NEO的NVM的字节码

3. *阅读《NEO智能合约开发（一）不可能完成的任务》，理解Verification与Application触发器区别。* https://www.cnblogs.com/crazylights/p/8427761.html


### homework 8

1. 为什么目前大多数区块链产品，都喜欢采用Leveldb数据库，而不是传统的关系型数据库？



### homework 9

1. 尝试通过使用ApplicationLog拿到调用合约时，产生的Event日志


### homework 10


1. 从github fork 分支代码，并以 neo_traning_group_{wechat group number}_{your name} 格式命名新分支

2. 完善neo demo，使其能够正常出块，发NEP5资产合约，并能完成合约转账

3. 最后提交Pull Request 到主分支上


