package service;

import java.util.ArrayList;
import dao.UsedCar_DAO;
import dto.UsedCar_VO;

public class UsedCar_Service {
	
	//dao를 포함
	private UsedCar_DAO dao;
	public UsedCar_Service() {
		dao=new UsedCar_DAO();
	}
	
	//모두 조회
	public ArrayList<UsedCar_VO> getAllMembers(){
		return dao.getAllMembers();
	}
	
	//데이터 추가 "INSERT INTO USEDCAR VALUES(?, ?, ?, ?, ?, ?, ?, ?, SYSDATE)"
	public ArrayList<UsedCar_VO> setMembers(String COMPANY,String NAME,int PRICE,int KM,String COLOR,String ENGINE,String ACCIDENT,String DATE){
		return dao.setMembers(COMPANY, NAME, PRICE, KM, COLOR, ENGINE, ACCIDENT, DATE);
	}
	
	//차량 가격 변경 "UPDATE USEDCAR SET "+car+"="+price+" where NAME = "+car
	public ArrayList<UsedCar_VO> UpdateCarPrice(String car,int price){
		return dao.UpdateCarPrice(car,price);
	}
	
	//차량 삭제 "DELETE FROM USEDCAR where name = "+car
	public ArrayList<UsedCar_VO> DeleteCar(String car) {
		return dao.DeleteCar(car);
	}
	
	//차량가격 조건 검색 "SELACT * FROM USEDCAR WHERE price="+min+" and price="+max;
	public ArrayList<UsedCar_VO> BetweenSearchCar(int min,int max){
		return dao.BetweenSearchCar(min, max);
	}
	
	//자유조건 검색   "SELECT * FROM USEDCAR WHERE NAME LIKE '%"+CarName+"%'";
	public ArrayList<UsedCar_VO> SearchCar(String CarName){
		return dao.SearchCar(CarName);
	}
}
