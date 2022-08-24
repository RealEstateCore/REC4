[Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Unoccupied_Discharge_Air_Flow_Setpoint](#)
# Unoccupied_Discharge_Air_Flow_Setpoint

**Display name:** Unoccupied Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Unoccupied_Discharge_Air_Flow_Setpoint;1

---


## Child interfaces
* [Unoccupied_Cooling_Discharge_Air_Flow_Setpoint](Unoccupied_Cooling_Discharge_Air_Flow_Setpoint.md)
* [Unoccupied_Heating_Discharge_Air_Flow_Setpoint](Unoccupied_Heating_Discharge_Air_Flow_Setpoint.md)

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
