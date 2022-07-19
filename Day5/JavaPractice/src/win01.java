import java.awt.Button;
import java.awt.FlowLayout;

import java.awt.Frame;
import javax.swing.*;
import java.awt.*;
import java.awt.event.WindowEvent;

import java.awt.event.*;
public class win01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame frm = new JFrame("Frame with Controls");

		 

	    frm.setLayout(null);



	    Label lblA = new Label("A = ");

	    frm.add(lblA);
	    lblA.setBounds( 10, 10, 60, 30);

	    TextField txtA = new TextField(20);
	    frm.add(txtA);
	    txtA.setBounds(72,10, 150, 30);

	    Label lblB = new Label("B = ");

	    frm.add(lblB);
	    lblB.setBounds(10, 70, 60, 30);

	    TextField txtB = new TextField(20);
	    frm.add(txtB);
	    txtB.setBounds(72, 70, 150, 30);

	    Label lblAns = new Label("Ans = ");
	    frm.add(lblAns);
	    lblAns.setBounds(10,130, 60, 30);
	    
	    TextField txtAns = new TextField(20);
	    frm.add(txtAns);
	    txtAns.setBounds(72, 130, 150, 30);
	    
	    Button btnAdd = new Button("+");
	    frm.add(btnAdd);
	    btnAdd.setBounds(10, 190, 50, 30);
	    
	    Button btnSub = new Button("-");
	    frm.add(btnSub);
	    btnSub.setBounds(75, 190, 50, 30);
	    
	    Button btnMul = new Button("*");
	    frm.add(btnMul);
	    btnMul.setBounds(130, 190, 50, 30);
	    
	    Button btnDiv = new Button("/");
	    frm.add(btnDiv);
	    btnDiv.setBounds(185, 190, 50, 30);

	    frm.setBounds(100, 100, 250, 300);

	    frm.setVisible(true);

	    btnAdd.addActionListener(new ActionListener(){ 
			public void actionPerformed(ActionEvent e) 
			{ 
				//JOptionPane.showMessageDialog(null,"Hello world!"); //呼叫msgbox
				double a = Double.parseDouble(txtA.getText());
				double b = Double.parseDouble(txtB.getText());
				txtAns.setText(String.valueOf(a+b));
			} 
		});        


	    btnSub.addActionListener(new ActionListener(){ 
			public void actionPerformed(ActionEvent e) 
			{ 
				//JOptionPane.showMessageDialog(null,"Hello world!"); //呼叫msgbox
				double a = Double.parseDouble(txtA.getText());
				double b = Double.parseDouble(txtB.getText());
				txtAns.setText(String.valueOf(a-b));
			} 
		});        


	    btnMul.addActionListener(new ActionListener(){ 
			public void actionPerformed(ActionEvent e) 
			{ 
				//JOptionPane.showMessageDialog(null,"Hello world!"); //呼叫msgbox

				double a = Double.parseDouble(txtA.getText());
				double b = Double.parseDouble(txtB.getText());
				txtAns.setText(String.valueOf(a*b));
			} 
		});        


	    btnDiv.addActionListener(new ActionListener(){ 
			public void actionPerformed(ActionEvent e) 
			{ 
				//JOptionPane.showMessageDialog(null,"Hello world!"); //呼叫msgbox

				double a = Double.parseDouble(txtA.getText());
				double b = Double.parseDouble(txtB.getText());
				txtAns.setText(String.valueOf(a/b));
			} 
		});        

	    frm.addWindowListener(

	            new WindowAdapter(){

	                public void windowClosing(WindowEvent e){

	                    System.exit(0);

	                }

	            }

	    );
	}

}
