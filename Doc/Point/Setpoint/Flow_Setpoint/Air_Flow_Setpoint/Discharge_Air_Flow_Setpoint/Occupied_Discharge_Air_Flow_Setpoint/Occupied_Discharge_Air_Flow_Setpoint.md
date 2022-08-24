[Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Occupied_Discharge_Air_Flow_Setpoint](.)
# Occupied_Discharge_Air_Flow_Setpoint

**Display name:** Occupied Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Discharge_Air_Flow_Setpoint;1

---


## Child interfaces
* [Occupied_Cooling_Discharge_Air_Flow_Setpoint](Occupied_Cooling_Discharge_Air_Flow_Setpoint.md)
* [Occupied_Heating_Discharge_Air_Flow_Setpoint](Occupied_Heating_Discharge_Air_Flow_Setpoint.md)

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
