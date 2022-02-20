--------------------------------------------------------
--  DDL for Table BOOK
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."BOOK" 
   (	"NAME" VARCHAR2(200 BYTE), 
	"AUTHOR" VARCHAR2(50 BYTE), 
	"PUBLISHER" VARCHAR2(50 BYTE), 
	"PUBLISHING_DATE" NUMBER, 
	"LIBRARY" VARCHAR2(30 BYTE), 
	"REFERENCE_LIBRARY" VARCHAR2(50 BYTE), 
	"BOOK_SYMBOL" VARCHAR2(50 BYTE), 
	"KDC" NUMBER, 
	"LOAN" VARCHAR2(15 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into SYSTEM.BOOK
SET DEFINE OFF;
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ���ڴ� ���ȿ��� �ؿ��ֽ����� �� ����','���̽�','�������Ͻ�',2021,'���̽��ε�������','[�ε�]�����ڷ��','327.856-���̽���',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���̿� ���� ������ Ȳ������) ���ѹα� ���̿�����:���̿�,�ݵ�ü�� �Ѻ���','Ȳ����','��ġķ��',2021,'���̽��ε�������','[�ε�]�����ڷ��','327.856-Ȳ������',327.856,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ ������:��ȣ�� ����Ҽ�','��ȣ��','����������',2021,'���̽��ε�������','[�ε�]�����ڷ��','813.6-��ȣ����',813.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('����Ž�� ����ī','�����ڿ� ����','��ä',2021,'���̽��ε�������','[�ε�]�����ڷ��','833.6-�����ڤ���',833.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� Ž���� 1,�ź��� ���','������ �� , ���¿� �׸�','�̷���',2021,'���̽��ε�������','[�ε�]�Ƶ��ڷ��','��400-����Ž-1',400,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('��Ž�� ��� ����:�̼��� ����Ҽ�','�̼���','���е���',2019,'���̽��ε�������','[�ε�]�����ڷ��','813.6-�̼��֤�=3',813.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ �ܲ��� ��û�̴���','��ι�','������',2017,'���̽��ε�������','[�ε�]�����ڷ��','��833.6-��ι̤���',833.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�ȳ�,�ܿ��','��� ���ձ��� ����ȸ','��ũ�Ͽ콺',2013,'���̽��ε�������','[�ε�]�����ڷ��','��080-���-17',80,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('Ʋ���� ������','��Ű�� ����','�����',2006,'���̽��ε�������','[�ε�]�����ڷ��','��375.1-��Ű�٤���=3',375.1,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ���','�輱��','����',2009,'���̽��ε�������','[�ε�]�����ڷ��','��990-������-11=2',990,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('ģ���� �������','�� �� ũ����','��Ʋ��',2001,'���̽��ε�������','[�ε�]�����ڷ��','��863-ũ��������',863,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('Why?)��ü ���','���Ƿ罺','������',2020,'���̽��ε�������','[�ε�]�Ƶ��ڷ��','��408-why-98',408,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ ������','������','�ϸ���',2021,'���̽��ε�������','[�ε�]�Ƶ��ڷ��','��813.6-��������',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ �ô�,���� �̷�','�� ������','��������',2020,'���̽��ε�������','[�ε�]�����ڷ��','321.97-����������',321.97,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�׳�� �� ��ȹ�� �ִ�','�����ó� ���̰�','�Ϻ�����',2021,'���̽��ε�������','[�ε�]�����ڷ��','833.6-�����ä���',833.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ������ ���� ��','�����ó� ���̰�','����',2019,'���̽��ε�������','[�ε�]�����ڷ��','833.6-�����ä���',833.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('����ö ����� ��Ƴ��� 1','������co','���̼���',2020,'���̽��ε�������','[�ε�]�Ƶ��ڷ��','��408-������-69',408,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('����ö ����� ��Ƴ��� 2','������co','���̼���',2020,'���̽��ε�������','[�ε�]�Ƶ��ڷ��','��408-������-70',408,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�ޱ��� ����','�����','â��',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','813.6-�������',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�׳�� �� ��ȹ�� �ִ�','�����ó� ���̰�','�Ϻ�����',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','833.6-�����ä���',833.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('����Ž�� ����ī','�����ڿ� ����','��ä',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','833.6-�����ڤ���',833.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� �ϳ��� �ǿܷ� �� �Ǳ� �����ߴ�','���ø� ��ο丮','������Ͽ콺',2019,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','189-���ø�����',189,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 1','����ȣ,�ֱԼ�','���е���',2020,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','810-����ȣ��-1',810,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 2','����ȣ,�ֱԼ�','���е���',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','810-����ȣ��-2',810,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�������� 1','HUN,����','������Ͽ콺 �̵��׷�',2017,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-�Ƥ�-1',818,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�������� 2','HUN,����','������Ͽ콺 �̵��׷�',2017,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-�Ƥ�-2',818,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�������� 3','HUN,����','������Ͽ콺 �̵��׷�',2017,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-�Ƥ�-3',818,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�������� 4','HUN,����','������Ͽ콺 �̵��׷�',2017,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-�Ƥ�-4',818,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�������� 5','HUN,����','������Ͽ콺 �̵��׷�',2017,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-�Ƥ�-5',818,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(�Ҽ���Ű�� �� ������ ������)�̱��ֽ�','�Ҽ���Ű','���',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','327.856-�Ҽ�����',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(�ֽ� ���ε鿡�� ����)���� �ʴ� ���� ��Ģ 49 : �ֽ� �밡���ǿ��ݺ��� ���� ö���� ����!','���ȯ','����Ʈ����Ͻ�',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','327.856-���ȯ��',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�׷��� �׷�:������ ������','������','�迵��',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','818-��������',818,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 1','���ѳ��� ����','�̷���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��813.6-���ѳ���-1',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 2','���ѳ��� ����','�̷���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��813.6-���ѳ���-2',813.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 3','���ѳ��� ����','�̷���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��813.6-���ѳ���-3',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���μ���)����� ����� 1, ������ ���� ������!','���μ�','�ܲ޾���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��909-���μ���-1',909,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���μ���)����� ����� 2, ��Ʋ���� �� ��','���μ�','�ܲ޾���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��909-���μ���-2',909,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���μ���)����� ����� 3, ���� �� - ����� ��ȭ','���μ�','�ܲ޾���',2019,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��909-���μ���-3',909,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���μ���)����� ����� 4, ��Ż���� ��-�θ����� ���� ��','���μ�','�ܲ޾���',2020,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��909-���μ���-4',909,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���μ���)����� ����� 5, ��Ż���� ��-������ ���׻�','���μ�','�ܲ޾���',2020,'���̽ø��߾ӵ�����','[�߾�]�Ƶ��ڷ��','��909-���μ���-5',909,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�뱸 ����','������','����',2009,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','��813.6-��������',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ��Ҿ�!','���̺�� �����','�ð��ִϾ�',2018,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','��843-����ʤ�',843,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ��ɲ� ���ڸ�','������','õ�հ���',2008,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','��491.508-��������=3',491.508,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('ä�ٴ�','ȫ�ڼ�','���ϻ�',1997,'���̽ø��߾ӵ�����','[�߾�]�ι�����','199-ȫ��������2',199,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 1','���ѳ��� ����','�̷���',2019,'���̽ú������','[����]�Ƶ��ڷ��','��813.8-���ѳ���-1',813.8,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 2','���ѳ��� ����','�̷���',2019,'���̽ú������','[����]�Ƶ��ڷ��','��813.8-���ѳ���-2',813.8,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���ѳ��� 3','���ѳ��� ����','�̷���',2019,'���̽ú������','[����]�Ƶ��ڷ��','��813.8-���ѳ���-3',813.8,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 1, ����������','������','����',2011,'���̽ú������','[����]�����ڷ��','813.6-������-1',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 2, �ٰ����� ����','������','����',2011,'���̽ú������','[����]�����ڷ��','813.6-������-2',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 3, ��������','������','����',2011,'���̽ú������','[����]�����ڷ��','813.6-������-3',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 4, ������ ��','������','����',2011,'���̽ú������','[����]�����ڷ��','813.6-������-4',813.6,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� 5 : ������, �鼺�� ��','������','����',2013,'���̽ú������','[����]�����ڷ��','813.6-������-5',813.6,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���μ��� ����� ����� 6, �̱� ��-�ε������ ����','���μ�','�ܲ޾���',2020,'���̽ú������','[����]�Ƶ��ڷ��','��909-���μ���-6',909,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�Ƹ��:�տ��� ����Ҽ�','�տ���','â��',2020,'���̽ú������','[����]�����ڷ��','813.7-�տ���',813.7,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ �������� Ż�� : ���ѹα� �������� ������Ʈ','�� ��','�����Ͻ�',2020,'���̽ú������','[����]�����ڷ��','327.8-������',327.8,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('������ ���ڵǱ� ���� : ���ѹα� �������� �׼� �÷�','�� ��','���ĳ븶��',2020,'���̽ú������','[����]�����ڷ��','327.04-��������',327.04,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(�Ҽ���Ű�� �� ������ ������)�̱��ֽ�','�Ҽ���Ű','���',2021,'���̽ú������','[����]�����ڷ��','327.856-�Ҽ�����',327.856,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(���ʺ��� źź�ϰ� �ٷ� ��Դ�) ��ġ���� ó������','�̼���','�̷��̵��',2021,'���̽ú������','[����]�����ڷ��','327.856-�̼�����',327.856,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�Ϸ� ���� ���� ���� ���� �ֽ�����','��â��','���',2019,'���̽ú������','[����]�����ڷ��','327.856-��â�Ǥ�',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�ֽ����� ������ �����ϱ�','�����','���',2020,'���̽ú������','[����]�����ڷ��','327.856-��ä����',327.856,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(�㿵����) �ֽ� Ÿ¥','�㿵��','�����',2020,'���̽ú������','[����]�����ڷ��','327.856-�㿵����',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('(������縦 ������) �ֽ����ڰ� �������ϴ�.','������','����Ʈ�Ͻ�',2020,'���̽ú������','[����]�����ڷ��','327.856-��������',327.856,'������');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('���� ���� �ϱ�','���� �׸��ǽ�','����������',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','843-�׸��Ǥ���',843,'���Ⱑ��');
Insert into SYSTEM.BOOK (NAME,AUTHOR,PUBLISHER,PUBLISHING_DATE,LIBRARY,REFERENCE_LIBRARY,BOOK_SYMBOL,KDC,LOAN) values ('�̵峪�� ���̺귯��','��Ʈ ���̱�','���÷翣��',2021,'���̽ø��߾ӵ�����','[�߾�]�����ڷ��','843-���̱פ���=2',843,'���Ⱑ��');
--------------------------------------------------------
--  Constraints for Table BOOK
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."BOOK" ADD CONSTRAINT "LOAN_CK" CHECK (loan in('������','���Ⱑ��')) ENABLE;
