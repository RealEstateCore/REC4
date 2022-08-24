[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Air_Temperature_Setpoint_Limit](../Air_Temperature_Setpoint_Limit.md) > [Discharge_Air_Temperature_Setpoint_Limit](.)
# Discharge_Air_Temperature_Setpoint_Limit

**Display name:** Discharge Air Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Temperature_Setpoint_Limit;1

---


## Child interfaces
* [Max_Discharge_Air_Temperature_Setpoint_Limit](../../../Limit/Max_Limit/Max_Temperature_Setpoint_Limit/Max_Discharge_Air_Temperature_Setpoint_Limit.md)
* [Min_Discharge_Air_Temperature_Setpoint_Limit](../../../Limit/Min_Limit/Min_Temperature_Setpoint_Limit/Min_Discharge_Air_Temperature_Setpoint_Limit.md)

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
