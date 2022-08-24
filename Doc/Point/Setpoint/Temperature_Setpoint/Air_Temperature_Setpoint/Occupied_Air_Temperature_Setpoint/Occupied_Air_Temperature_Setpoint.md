[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Occupied_Air_Temperature_Setpoint](.)
# Occupied_Air_Temperature_Setpoint

**Display name:** Occupied Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Occupied_Discharge_Air_Temperature_Setpoint](Occupied_Discharge_Air_Temperature_Setpoint.md)
* [Occupied_Air_Temperature_Cooling_Setpoint](Occupied_Air_Temperature_Cooling_Setpoint.md)
* [Occupied_Air_Temperature_Heating_Setpoint](Occupied_Air_Temperature_Heating_Setpoint.md)
* [Occupied_Return_Air_Temperature_Setpoint](../Return_Air_Temperature_Setpoint/Occupied_Return_Air_Temperature_Setpoint.md)
* [Occupied_Room_Air_Temperature_Setpoint](../Room_Air_Temperature_Setpoint/Occupied_Room_Air_Temperature_Setpoint.md)
* [Occupied_Supply_Air_Temperature_Setpoint](../Supply_Air_Temperature_Setpoint/Occupied_Supply_Air_Temperature_Setpoint.md)
* [Occupied_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Occupied_Zone_Air_Temperature_Setpoint.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
