[Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Heating_Discharge_Air_Flow_Setpoint](.)
# Heating_Discharge_Air_Flow_Setpoint

**Display name:** Heating Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Discharge_Air_Flow_Setpoint;1

---


## Child interfaces
* [Occupied_Heating_Discharge_Air_Flow_Setpoint](../Occupied_Discharge_Air_Flow_Setpoint/Occupied_Heating_Discharge_Air_Flow_Setpoint.md)
* [Unoccupied_Heating_Discharge_Air_Flow_Setpoint](../Unoccupied_Discharge_Air_Flow_Setpoint/Unoccupied_Heating_Discharge_Air_Flow_Setpoint.md)

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
