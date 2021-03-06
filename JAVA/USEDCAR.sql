--------------------------------------------------------
--  DDL for Table USEDCAR
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."USEDCAR" 
   (	"COMPANY" VARCHAR2(30 BYTE), 
	"NAME" VARCHAR2(30 BYTE), 
	"PRICE" NUMBER(*,0), 
	"KM" NUMBER(*,0), 
	"COLOR" VARCHAR2(30 BYTE), 
	"ENGINE" VARCHAR2(20 BYTE), 
	"ACCIDENT" VARCHAR2(20 BYTE), 
	"BUY_DATE" DATE
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into SYSTEM.USEDCAR
SET DEFINE OFF;
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('르노삼성','SM3',1250,25938,'은색','가솔린','n',to_date('19/05/23','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','악센트',930,28089,'쥐색','가솔린','n',to_date('17/07/13','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('기아','더뉴모닝',750,32689,'베이지','가솔린','n',to_date('17/01/05','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','코나',2020,11755,'흰색','디젤','n',to_date('18/01/02','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('기아','스포티지',1570,47260,'은색','디젤','n',to_date('16/08/05','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('기아','K7',2690,36741,'검정색','LPG','n',to_date('18/02/23','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('GM대우','다마스',450,39809,'청색','LPG','n',to_date('15/11/16','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','그랜저',1590,84167,'검정색','LPG','n',to_date('14/07/08','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('르노삼성','QM6',2900,11,'흰색','LPG','n',to_date('21/05/14','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','아반떼',2560,8604,'쥐색','하이브리드','y',to_date('21/04/02','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('기아','K5',920,112281,'흰색','하이브리드','n',to_date('12/11/28','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('기아','쏘렌토',4600,19,'빨강색','하이브리드','n',to_date('20/08/10','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('쌍용','코란도',2149,41945,'흰색','디젤','n',to_date('19/08/30','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','포터',1190,124316,'흰색','디젤','n',to_date('15/09/10','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('벤츠','GLA클래스',5200,9664,'쥐색','가솔린','n',to_date('20/11/24','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('쌍용','베리뉴티볼리',2280,2124,'흰색','가솔린','n',to_date('20/03/04','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('제네시스','G70',3650,25237,'회색','가솔린','n',to_date('19/02/19','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('BMW','F30',1620,107650,'흰색','디젤','n',to_date('14/08/19','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('현대','YF쏘나타',380,199724,'검정','가솔린','n',to_date('09/12/23','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('제네시스','G70',3520,66068,'검정','가솔린','n',to_date('18/05/08','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('쉐보레','대우 토스카',109,166642,'검정','가솔린','y',to_date('06/05/04','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('르노삼성','SM5뉴임프레션',150,250735,'은색','가솔린','n',to_date('07/07/23','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('포르쉐','카이엔(2세대)',7630,93247,'흰색','가솔린','n',to_date('21/03/26','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('BMW','X4M',8200,19100,'쥐색','가솔린','n',to_date('20/05/29','RR/MM/DD'));
Insert into SYSTEM.USEDCAR (COMPANY,NAME,PRICE,KM,COLOR,ENGINE,ACCIDENT,BUY_DATE) values ('랜드로버','레인지로버(4세대)',17950,23000,'흰색','가솔린','n',to_date('18/11/21','RR/MM/DD'));
--------------------------------------------------------
--  Constraints for Table USEDCAR
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("COMPANY" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("NAME" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("PRICE" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("KM" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("COLOR" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("ENGINE" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("ACCIDENT" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" MODIFY ("BUY_DATE" NOT NULL ENABLE);
  ALTER TABLE "SYSTEM"."USEDCAR" ADD CONSTRAINT "ACCIDENTR_CK" CHECK (accident in('y','n')) ENABLE;
