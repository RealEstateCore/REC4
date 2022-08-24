[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Flow_Setpoint](../../Flow_Setpoint.md) > [Water_Flow_Setpoint](../Water_Flow_Setpoint.md) > [Hot_Water_Flow_Setpoint](Hot_Water_Flow_Setpoint.md) > [Entering_Hot_Water_Flow_Setpoint](#)
# Entering_Hot_Water_Flow_Setpoint

**Display name:** Entering Hot Water Flow Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Entering_Hot_Water_Flow_Setpoint;1

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
