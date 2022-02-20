package dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

import dto.UsedCar_VO;

public class UsedCar_DAO {
	private ArrayList<UsedCar_VO> dtos;
	private Connection con;
	private Statement st;
	private ResultSet rs;
	
	private PreparedStatement pstmt;
	
	public UsedCar_DAO() {
		dtos = new ArrayList<UsedCar_VO>();
		try {
		String user = "system";
        String pw = "mj4660mp";
		String url="jdbc:oracle:thin:@localhost:1521:XE";
		Class.forName("oracle.jdbc.driver.OracleDriver");
			con=DriverManager.getConnection(url,user,pw);
			st=con.createStatement();
		}catch(Exception e) {
			System.out.println("데이터베이스 연결 오류:"+e.getMessage());
		}	
	}
	
	//모두조회
	public ArrayList<UsedCar_VO> getAllMembers() {
		String SQL="SELECT * FROM USEDCAR";
		try {
			rs=st.executeQuery(SQL);
			while(rs.next()) {	
				String company = rs.getString("company");
				String name = rs.getString("name");
				int price = rs.getInt("price");
				int km	=	rs.getInt("km");
				String color = rs.getString("color");
				String engine =rs.getString("engine");
				String accident =rs.getString("accident");
				String buy_date =rs.getString("buy_date");
				UsedCar_VO VO=new UsedCar_VO(company,name,price,km,color,engine,accident,buy_date);
				dtos.add(VO);
				//ArrayList에 회원정보 추가
			}
		}catch(SQLException e) {
			e.printStackTrace();
			System.out.println("데이터베이스 연결 오류:"+e.getMessage());
		}
		return dtos;
	}
	//데이터 추가
	public ArrayList<UsedCar_VO> setMembers(String COMPANY,String NAME,int PRICE,int KM,String COLOR,String ENGINE,String ACCIDENT,String DATE) {
		String SQL="INSERT INTO USEDCAR VALUES(?, ?, ?, ?, ?, ?, ?, ?)";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, COMPANY);
			pstmt.setString(2, NAME);
			pstmt.setInt(3, PRICE);
			pstmt.setInt(4, KM);
			pstmt.setString(5, COLOR);
			pstmt.setString(6, ENGINE);
			pstmt.setString(7, ACCIDENT);
			pstmt.setString(8, DATE);
			pstmt.executeUpdate();
			System.out.println("데이터 추가 완료");
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println("데이터베이스 연결 오류:"+e.getMessage());
		}
		return dtos;
		
	}
	//차량 가격 수정
	public ArrayList<UsedCar_VO> UpdateCarPrice(String car,int price) {
		String SQL = "UPDATE USEDCAR SET price=? where name=?";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setInt(1, price);
			pstmt.setString(2, car);
			pstmt.executeUpdate();
			System.out.println("가격수정완료");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		};
		return dtos;
	}
	
	//차량 삭제
	public ArrayList<UsedCar_VO> DeleteCar(String car) {
		String SQL = "DELETE FROM USEDCAR where name =?";
		try {
			pstmt = con.prepareStatement(SQL);
			pstmt.setString(1, car);
			pstmt.executeUpdate();
			System.out.println("삭제완료");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		};
		return dtos;
	}
	//a에서b사이의 가격 검색
	public ArrayList<UsedCar_VO> BetweenSearchCar(int min,int max) {
		String SQL = "SELECT * FROM USEDCAR WHERE price>="+min+" and price<="+max;
		try {
			pstmt = con.prepareStatement(SQL);
			rs=st.executeQuery(SQL);
			while(rs.next()) {	
				String company = rs.getString("COMPANY");
				String name = rs.getString("NAME");
				int price = rs.getInt("PRICE");
				int km	=	rs.getInt("KM");
				String color = rs.getString("COLOR");
				String engine =rs.getString("ENGINE");
				String accident =rs.getString("ACCIDENT");
				String buy_date =rs.getString("BUY_DATE");
				UsedCar_VO VO=new UsedCar_VO(company,name,price,km,color,engine,accident,buy_date);
				dtos.add(VO);
				pstmt.executeUpdate();
				}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		};
		return dtos;
	}
	
	
	public ArrayList<UsedCar_VO> SearchCar(String CarName) {
		String SQL = "SELECT * FROM USEDCAR WHERE NAME LIKE '%"+CarName+"%'";
		try {
			pstmt = con.prepareStatement(SQL);
			rs=st.executeQuery(SQL);
			while(rs.next()) {	
				String company = rs.getString("COMPANY");
				String name = rs.getString("NAME");
				int price = rs.getInt("PRICE");
				int km	=	rs.getInt("KM");
				String color = rs.getString("COLOR");
				String engine =rs.getString("ENGINE");
				String accident =rs.getString("ACCIDENT");
				String buy_date =rs.getString("BUY_DATE");
				UsedCar_VO VO=new UsedCar_VO(company,name,price,km,color,engine,accident,buy_date);
				dtos.add(VO);
				pstmt.executeUpdate();
				}
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		};
		return dtos;
	}
}
