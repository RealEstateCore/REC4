[Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Flow_Setpoint](../../../Flow_Setpoint.md) > [Air_Flow_Setpoint](../../Air_Flow_Setpoint.md) > [Discharge_Air_Flow_Setpoint](../Discharge_Air_Flow_Setpoint.md) > [Occupied_Discharge_Air_Flow_Setpoint](Occupied_Discharge_Air_Flow_Setpoint.md) > [Occupied_Cooling_Discharge_Air_Flow_Setpoint](.)
# Occupied_Cooling_Discharge_Air_Flow_Setpoint

**Display name:** Occupied Cooling Discharge Air Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Occupied_Cooling_Discharge_Air_Flow_Setpoint;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
