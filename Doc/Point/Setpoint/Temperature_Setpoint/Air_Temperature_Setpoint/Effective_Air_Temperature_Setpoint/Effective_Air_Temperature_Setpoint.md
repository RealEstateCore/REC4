[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Effective_Air_Temperature_Setpoint](.)
# Effective_Air_Temperature_Setpoint

**Display name:** Effective Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Effective_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Effective_Discharge_Air_Temperature_Setpoint](Effective_Discharge_Air_Temperature_Setpoint.md)
* [Effective_Air_Temperature_Cooling_Setpoint](Effective_Air_Temperature_Cooling_Setpoint.md)
* [Effective_Air_Temperature_Heating_Setpoint](Effective_Air_Temperature_Heating_Setpoint.md)
* [Effective_Return_Air_Temperature_Setpoint](../Return_Air_Temperature_Setpoint/Effective_Return_Air_Temperature_Setpoint.md)
* [Effective_Room_Air_Temperature_Setpoint](../Room_Air_Temperature_Setpoint/Effective_Room_Air_Temperature_Setpoint.md)
* [Effective_Supply_Air_Temperature_Setpoint](../Supply_Air_Temperature_Setpoint/Effective_Supply_Air_Temperature_Setpoint.md)
* [Effective_Zone_Air_Temperature_Setpoint](../Zone_Air_Temperature_Setpoint/Effective_Zone_Air_Temperature_Setpoint.md)

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
