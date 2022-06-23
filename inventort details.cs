// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
import java.io.File;
import java.io.IOException;

import org.codehaus.jackson.JsonParseException;
import org.codehaus.jackson.map.JsonMappingException;
import org.codehaus.jackson.map.ObjectMapper;




public class InventoryDetails
{

	public static void main(String[] args) throws JsonParseException, JsonMappingException, IOException 
    {

		String path = "/home/admin1/eclipse-workspace/BridgeLabzFellowshipPrograms/src/"
				+ "com/bridgelabz/jsonfiles/inventory_details.json";
	String path2 = "/home/admin1/eclipse-workspace/BridgeLabzFellowshipPrograms/src/"
			+ "com/bridgelabz/jsonfiles/inventory_detailsOutput.json";

	ObjectMapper mapper = new ObjectMapper();

	
	InventoryDetailModel model = mapper.readValue(new File(path), InventoryDetailModel.class);

		int total = 0;
	System.out.println("Rice : " + model.getRice().get(0).getName());
		System.out.println("Price : " + model.getRice().get(0).getPrice_per_kg());
		total += model.getRice().get(0).getPrice_per_kg();
	System.out.println("wheats : " + model.getWheats().get(0).getName());
		System.out.println("Price : " + model.getWheats().get(0).getPrice_per_kg());
		total += model.getWheats().get(0).getPrice_per_kg();
	System.out.println("pulses : " + model.getPulses().get(0).getName());
		System.out.println("Price : " + model.getPulses().get(0).getPrice_per_kg());
		total += model.getPulses().get(0).getPrice_per_kg();
	System.out.println("\nTotal : " + total);

	// code for writing all details into new file
	model.setTotal(total);
		mapper.writeValue(new File(path2), model);
		System.out.println("\nWrite into file is completed!!!");
     }
}
