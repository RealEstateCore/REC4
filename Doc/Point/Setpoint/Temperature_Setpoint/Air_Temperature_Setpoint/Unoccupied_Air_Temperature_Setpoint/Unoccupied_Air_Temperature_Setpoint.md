[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Unoccupied_Air_Temperature_Setpoint](.)
# Unoccupied_Air_Temperature_Setpoint

**Display name:** Unoccupied Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Unoccupied_Discharge_Air_Temperature_Setpoint](Unoccupied_Discharge_Air_Temperature_Setpoint.md)
* [Unoccupied_Return_Air_Temperature_Setpoint](Unoccupied_Return_Air_Temperature_Setpoint.md)
* [Unoccupied_Room_Air_Temperature_Setpoint](Unoccupied_Room_Air_Temperature_Setpoint.md)
* [Unoccupied_Supply_Air_Temperature_Setpoint](Unoccupied_Supply_Air_Temperature_Setpoint.md)
* [Unoccupied_Air_Temperature_Cooling_Setpoint](Unoccupied_Air_Temperature_Cooling_Setpoint.md)
* [Unoccupied_Air_Temperature_Heating_Setpoint](Unoccupied_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Unoccupied_Zone_Air_Temperature_Setpoint.md)

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
