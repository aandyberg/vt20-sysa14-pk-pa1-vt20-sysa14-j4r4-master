
package org.rentacar;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JComboBox;
import javax.swing.JTextArea;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JScrollPane;


public class Interface {

	private JFrame frame;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Interface window = new Interface();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Interface() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 554, 326);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		String [] comboOptions =  {"GetAllKeys", "GetAllConstraints", "GetAllTables1", "GetAllTables2", "GetAllColumnsFromEmp1", "GetAllColumnsFromEmp2", "GetMostAbsent", "GetAllAbsense2004","GetAllIndexes", "GetInformationAboutEmployeeAndRelatives", "GetMetaDataFromEmpAndRelatedTables"};
		
		final JComboBox comboBox = new JComboBox(comboOptions);
		comboBox.setBounds(92, 48, 367, 22);
		frame.getContentPane().add(comboBox);
		
		final JTextArea textArea = new JTextArea();
		textArea.setEditable(false);
		textArea.setBounds(-11, 115, 518, 161);
		frame.getContentPane().add(textArea);
		
		JScrollPane scrollPane = new JScrollPane(textArea);
		scrollPane.setBounds(10, 128, 518, 148);
		frame.getContentPane().add(scrollPane);
		
		
				
		
	
		
		

		JButton btnNewButton = new JButton("Show");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String comboBoxChoice = comboBox.getSelectedItem().toString();
				WebServiceAss6SoapProxy proxy = new WebServiceAss6SoapProxy();
				try {
				if (comboBoxChoice.equals("GetAllKeys")) {
					String tmp = proxy.getAllKeys();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
				}
				else if (comboBoxChoice.equals("GetAllConstraints")) {
					String tmp = proxy.getAllTableConstraints();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllTables1")) {
					String tmp = proxy.getAllTablesDB1();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllTables2")) {
					String tmp = proxy.getAllTablesDB2();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllColumnsFromEmp1")) {
					String tmp = proxy.getAllColumnsFromEmp1();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllColumnsFromEmp2")) {
					String tmp = proxy.getAllColumnsFromEmp2();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetMostAbsent")) {
					String tmp = proxy.getNameAbsentMost();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllAbsense2004")) {
					String tmp = proxy.getInfoEmpSickness2004();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetAllIndexes")) {
					String tmp = proxy.getAllIndexes();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals( "GetInformationAboutEmployeeAndRelatives")) {
					String tmp = proxy.getInfoFromEmpAndRelatives();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				else if (comboBoxChoice.equals("GetMetaDataFromEmpAndRelatedTables")) {
					String tmp = proxy.getMetaDataFromEmpAndRelated();
					String output = tmp.replace("},", "}\n");
					textArea.setText(output);
					
				}
				} catch (Exception ex) {}
				
			}
		});
		btnNewButton.setBounds(10, 48, 72, 23);
		frame.getContentPane().add(btnNewButton);
		
	}
	
}

